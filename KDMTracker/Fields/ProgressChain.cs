using System;
using System.Collections.Generic;

namespace KDMTracker
{
	public class ProgressChain
	{
		uint Progress;
		uint[] Milestones;
		uint Max;

		public ProgressChain (uint[] milestones, uint max)
		{
			Progress = 0;
			Milestones = milestones;
			Max = max;
		}

		public ProgressChain (uint[] milestones, uint max, uint progress)
		{
			Progress = progress;
			Milestones = milestones;
			Max = max;
		}
	}
}

