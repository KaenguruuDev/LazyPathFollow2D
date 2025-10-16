using System;
using Godot;

namespace LazyPathFollow2D;

public partial class LazyPathFollow2D : PathFollow2D
{
	[ExportCategory("Rotation")]
	[Export(PropertyHint.Range, hintString: "0,1,0.001")]
	private float _angleCorrection = 1f;

	[Export(PropertyHint.Range, hintString: "0,360,1")]
	private int _maxAngleCorrectionPerTick = 360;

	[ExportCategory("Position")]
	[Export(PropertyHint.Range, hintString: "0,1,0.001")]
	private float _positionCorrection = 1f;

	[Export]
	private Vector2 _maxPositionCorrectionPerTick = new (float.MaxValue, float.MaxValue);

	[ExportCategory("Remote")]
	[Export]
	public Node2D? RemoteTarget;

#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
	[Obsolete("Do not override _Process. Override OnProcess() instead.")]
	public override void _Process(double delta)
	{
		OnProcess(delta);

		if (RemoteTarget is null)
			return;

		var targetRotation = Mathf.LerpAngle(RemoteTarget.Rotation, Rotation, _angleCorrection);
		var targetPosition = RemoteTarget.GlobalPosition.Lerp(GlobalPosition, _positionCorrection);
		RemoteTarget.Rotation += Mathf.DegToRad(Mathf.Clamp(Mathf.RadToDeg(targetRotation - RemoteTarget.Rotation),
			-_maxAngleCorrectionPerTick, _maxAngleCorrectionPerTick));

		var positionDelta = targetPosition - RemoteTarget.GlobalPosition;
		RemoteTarget.GlobalPosition +=
			positionDelta.Clamp(-_maxPositionCorrectionPerTick, _maxPositionCorrectionPerTick);
	}


#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member

	protected virtual void OnProcess(double delta)
	{
	}
}