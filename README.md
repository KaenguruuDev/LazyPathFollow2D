# LazyPathFollow2D

---

extends `PathFollow2D`

**`[Export] float AngleCorrection`**: Correction rate for remote rotation. A value of 1.0 means instant snapping (= the same behavior as a normal PathFollow2D node). A value of 0.0 will disable rotation adjustment completely.

**`[Export] float PositionCorrection`**: Correction rate for remote position. A value of 1.0 means instant snapping (= the same behavior as a normal PathFollow2D node). A value of 0.0 will disable positional adjustment completely.

**`[Export] Node2D RemoteTarget`**: The node to apply the lazy following to. This node should not be a child of a `LazyPathFollow2D` node.

---

Author: KaenguruuDev

https://kaenguruu.dev

