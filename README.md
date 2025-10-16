<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16"><path fill="#8da5f3" d="m13 0-3 4h1.947c-.138 1.32-.558 1.907-1.084 2.275-.644.451-1.713.606-2.963.73s-2.681.221-3.912 1.083c-.892.625-1.532 1.652-1.818 3.096a2 2 0 1 0 1.98.183c.193-.885.553-1.337.987-1.64.644-.451 1.713-.606 2.963-.73s2.681-.221 3.912-1.083c1.053-.737 1.755-2.032 1.937-3.914H16l-3-4z"/></svg>
![PathFollow2D](https://github.com/user-attachments/assets/71306e65-fe43-4fc6-94d8-89eceac90aa1) LazyPathFollow2D

---

extends `PathFollow2D`

**`[Export] float AngleCorrection`**: Correction rate for remote rotation. A value of 1.0 means instant snapping (= the same behavior as a normal PathFollow2D node). A value of 0.0 will disable rotation adjustment completely.

**`[Export] float PositionCorrection`**: Correction rate for remote position. A value of 1.0 means instant snapping (= the same behavior as a normal PathFollow2D node). A value of 0.0 will disable positional adjustment completely.

**`[Export] Node2D RemoteTarget`**: The node to apply the lazy following to. This node should not be a child of a `LazyPathFollow2D` node.

---

Author: KaenguruuDev

https://kaenguruu.dev

