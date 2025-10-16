using System;
using Godot;

namespace LazyPathFollow2D;

public partial class LazyPathFollow2D : PathFollow2D
{
	[Export(PropertyHint.Range, hintString: "0,1,0.001,TEST")]
	private float _angleCorrection = 1f;

	[Export(PropertyHint.Range, hintString: "0,1,0.001")]
	private float _positionCorrection = 1f;

	[Export]
	public Node2D? RemoteTarget;

#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
	[Obsolete("Do not override _Process. Override OnProcess() instead.")]
	public override void _Process(double delta)
	{
		OnProcess(delta);

		if (RemoteTarget is null)
			return;

		RemoteTarget.Rotation = Mathf.LerpAngle(RemoteTarget.Rotation, Rotation, _angleCorrection);
		RemoteTarget.GlobalPosition = RemoteTarget.GlobalPosition.Lerp(GlobalPosition, _positionCorrection);
	}


#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member

	protected virtual void OnProcess(double delta)
	{
	}
}