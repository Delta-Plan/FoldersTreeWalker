using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolkerCore.Contracts;

namespace FoldersTreeWalker
{
	public class Main
	{
		public ObservableCollection<ITreeItem> FoldersTree { get; set; }
	}
}
