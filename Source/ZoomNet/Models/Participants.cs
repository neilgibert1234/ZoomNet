using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomNet.Models
{
	/// <summary>
	/// Used for participant report
	/// </summary>
	public class Participants : Participant
	{
		/// <summary>
		/// Gets or sets the participant's Join Time.
		/// </summary>
		[JsonProperty(PropertyName = "join_time")]

		public string JoinTime { get; set; }

		/// <summary>
		/// Gets or sets the participant's Leave Time.
		/// </summary>
		[JsonProperty(PropertyName = "leave_time")]
		public string LeaveTime { get; set; }

		/// <summary>
		/// Gets or sets the participant's Duration.
		/// </summary>
		[JsonProperty(PropertyName = "duration")]
		public int Duration { get; set; }
	}
}
