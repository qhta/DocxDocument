using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface IFoundFiles: IEnumerable
{
  public string this[int Index] { get; }
  public int Count { get; }
}
