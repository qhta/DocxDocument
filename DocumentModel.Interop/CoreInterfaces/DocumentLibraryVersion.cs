using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentLibraryVersion: InteropObject
{
  object Modified { get; }
  int Index { get; }
  string ModifiedBy { get; }
  string Comments { get; }
  void Delete();
  object Open();
  object Restore();
}