#if TOOLS
using Godot;
using System;

namespace LazyPathFollow2D;

[Tool]
public partial class LazyPathFollow2DPlugin : EditorPlugin
{
	public override void _EnterTree()
	{
		var baseIcon = EditorInterface.Singleton.GetBaseControl().GetThemeIcon("PathFollow2D", "EditorIcons");
		AddCustomType(
			"LazyPathFollow2D",
			"PathFollow2D",
			GD.Load<Script>("res://addons/LazyPathFollow2D/LazyPathFollow2D.cs"),
			baseIcon);
	}

	public override void _ExitTree()
	{
		RemoveCustomType("LazyPathFollow2D");
	}
}
#endif