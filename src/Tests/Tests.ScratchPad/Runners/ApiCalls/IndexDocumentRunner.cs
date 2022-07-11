﻿using Tests.Domain;

namespace Tests.ScratchPad.Runners.ApiCalls
{
	public class IndexDocumentRunner : RunBase
	{
		protected override int LoopCount => 10_000;

		protected override RoutineBase Routine() => Loop(() => new Project { Name = "x" }, (c, d) => c.Index(d));
	}
}