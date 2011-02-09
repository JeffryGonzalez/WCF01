using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoStore.Contracts;

namespace VideoStore.Domain
{
	public class VideoLookup : IVideoLookup
	{
		public string GetTitleOfTopSellingVideo()
		{
			return string.Format("As of {0:T} it is Faces", DateTime.Now);
		}
	}
}
