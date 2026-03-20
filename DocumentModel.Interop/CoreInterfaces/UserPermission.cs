using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface UserPermission: InteropObject
{
  string UserId { get; }
  int Permission { get; set; }
  object ExpirationDate { get; set; }
  void Remove();
}