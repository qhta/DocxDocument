using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface DocumentLibraryVersion
{
  public void Delete();
  public object Open();
  public object Restore();
}
