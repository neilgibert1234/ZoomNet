using Newtonsoft.Json;

namespace ZoomNet.Models
{
	/// <summary>
	/// Used for participant report.
	/// </summary>
	public class Participants
	{
		/// <summary>
		/// Gets or sets the participant id.
		/// </summary>
		/// <value>
		/// The id.
		/// </value>
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the participant uuid.
		/// </summary>
		/// <value>
		/// The id.
		/// </value>
		[JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
		public string Uuid { get; set; }

		/// <summary>
		/// Gets or sets the participant's display name.
		/// </summary>
		[JsonProperty(PropertyName = "name")]
		public string DisplayName { get; set; }

		/// <summary>
		/// Gets or sets the participant's email address.
		/// </summary>
		[JsonProperty(PropertyName = "user_email")]
		public string Email { get; set; }

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

		/// <summary>
		/// Gets or sets the participant's Attentiveness Score.
		/// </summary>
		[JsonProperty(PropertyName = "attentiveness_score")]
		public string AttentivenessScore { get; set; }
	}
}
