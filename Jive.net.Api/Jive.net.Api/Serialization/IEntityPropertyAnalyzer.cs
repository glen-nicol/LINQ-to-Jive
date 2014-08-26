﻿using System.Collections.Generic;

namespace Jive.net.Serialization
{
	public interface IEntityPropertyAnalyzer<in T>
	{
		IEnumerable<EntityPropertyMap> RequiredProperties(T entity);
		IEnumerable<EntityPropertyMap> OptionalProperties(T entity);
		//IEnumerable<EntityPropertyMap> ExtraProperties(T entity);
	}
}