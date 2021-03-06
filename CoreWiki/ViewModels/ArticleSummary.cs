﻿using NodaTime;

namespace CoreWiki.ViewModels
{
	public class ArticleSummary
	{
		public string Slug { get; set; }
		public string Topic { get; set; }
		public Instant Published { get; set; }
		public int ViewCount { get; set; }
	}
}
