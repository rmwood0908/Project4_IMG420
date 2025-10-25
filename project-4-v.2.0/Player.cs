using Godot;

public partial class Player : CharacterBody2D
{
	// --- Tunables ---
	[Export] public float Speed = 300f;
	[Export] public float JumpVelocity = -520f;          // stronger launch (try -520 to -620)
	[Export] public float RiseHoldMultiplier = 0.55f;     // gravity while rising AND jump is held  (0.4–0.7)
	[Export] public float RiseCutMultiplier  = 1.8f;      // gravity while rising but jump NOT held (short hop)
	[Export] public float FallMultiplier     = 1.6f;      // gravity while falling (snappier fall)
	[Export] public float MaxFallSpeed       = 1400f;     // cap terminal velocity

	private AnimatedSprite2D _sprite;

	public override void _Ready()
	{
		_sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		_sprite.Play("idle");
	}

	public override void _PhysicsProcess(double delta)
	{
		float dt = (float)delta;
		Vector2 v = Velocity;
		float g = GetGravity().Y;
		
		float dir = Input.GetAxis("ui_left", "ui_right");
		v.X = (dir != 0) ? dir * Speed : Mathf.MoveToward(v.X, 0, Speed);
		
		bool jumpPressed  = Input.IsActionJustPressed("ui_accept") || Input.IsActionJustPressed("ui_up");
		bool jumpHeld     = Input.IsActionPressed("ui_accept")     || Input.IsActionPressed("ui_up");

		if (jumpPressed && IsOnFloor())
			v.Y = JumpVelocity;

		if (v.Y < 0)
		{
			float mult = jumpHeld ? RiseHoldMultiplier : RiseCutMultiplier;
			v.Y += g * mult * dt;
		}
		else
		{
			v.Y += g * FallMultiplier * dt;
		}

		if (v.Y > MaxFallSpeed)
			v.Y = MaxFallSpeed;

		// Sprite facing & anim
		if (dir != 0) _sprite.FlipH = dir < 0;

		if (!IsOnFloor())
			_sprite.Play("idle"); // swap to "jump" if you add one
		else if (Mathf.Abs(v.X) > 1f)
			_sprite.Play("walk");
		else
			_sprite.Play("idle");

		Velocity = v;
		MoveAndSlide();
	}
}
