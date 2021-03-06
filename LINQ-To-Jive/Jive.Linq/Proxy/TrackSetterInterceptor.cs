﻿using System;
using Castle.DynamicProxy;

namespace Jive.Linq.Proxy
{
	public class TrackSetterInterceptor : IInterceptor
	{
		private readonly ITrackChanges _tracker;

		public TrackSetterInterceptor(ITrackChanges tracker)
		{
			if (tracker == null)
			{
				throw new ArgumentNullException("tracker");
			}
			_tracker = tracker;
		}

		public void Intercept(IInvocation invocation)
		{

			var getter = invocation.TargetType.GetProperty( invocation.Method.Name.Substring(4));
			_tracker.MarkMemberChanged(getter);
			invocation.Proceed();
		}
	}
}