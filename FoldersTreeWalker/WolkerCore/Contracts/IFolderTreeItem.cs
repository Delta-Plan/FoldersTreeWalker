using System;
using System.Collections.Generic;
using System.Text;

namespace WolkerCore.Contracts
{
	public interface IFolderTreeItem : ITreeItem
	{
		IEnumerable<IFolderTreeItem> Children { get; }

	}
}
