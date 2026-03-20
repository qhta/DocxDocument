using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface DocumentLibraryVersion: InteropObject
{
  public object Modified { get; }
  public int Index { get; }
  public string ModifiedBy { get; }
  public string Comments { get; }
}
