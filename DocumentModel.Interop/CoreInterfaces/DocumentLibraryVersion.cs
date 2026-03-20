using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentLibraryVersion: InteropObject
{
  public object Modified { get; }
  public int Index { get; }
  public string ModifiedBy { get; }
  public string Comments { get; }
  public void Delete();
  public object Open();
  public object Restore();
}
