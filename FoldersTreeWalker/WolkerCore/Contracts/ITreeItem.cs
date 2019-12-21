using System;
using System.Collections.Generic;
using System.Text;

namespace WolkerCore.Contracts
{
	public interface ITreeItem
	{
		int Id { get; }

		string Name { get; }

		string Path { get; }

		long Bytes { get; }
	}
}
