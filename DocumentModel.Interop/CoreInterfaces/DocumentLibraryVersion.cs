using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DocumentLibraryVersion: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Modified { get; }
  int Index { get; }
  object Parent { get; }
  string ModifiedBy { get; }
  string Comments { get; }
  void Delete();
  object Open();
  object Restore();
}