﻿using System;

namespace NGTools
{
	public interface ICollectionModifier
	{
		int		Size { get; }
		Type	SubType { get; }

		object	Get(int index);
		void	Set(int index, object value);
	}
}