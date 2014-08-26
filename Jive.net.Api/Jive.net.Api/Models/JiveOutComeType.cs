﻿using System.Collections.Generic;
using Jive.net.Serialization;

namespace Jive.net.Models
{
	[JiveApiReadOnly]
	public class JiveOutComeType : IJiveApiObject
	{
		public string CommunityAudience	 { get; private set; }
		public string ConfirmContentEdit { get; private set; }
		public bool ConfirmExclusion { get; set; }
		public bool ConfirmUnmark { get; private set; }
		public IEnumerable<JiveField> Fields { get; private set; }
		public bool GeneralNote { get; set; }
		public string ApiId { get { return Id; } }
		public string Id { get; private set; }
		public string Name { get; private set; }
		public bool NoteRequired { get; private set; }
		public IEnumerable<IJiveResource> Resources { get; private set; }
		public string ApiPath { get { return "outcomeTypes"; } }
		public bool Shareable { get; private set; }
		public bool UrlAllowed { get; private set; }

	}
}