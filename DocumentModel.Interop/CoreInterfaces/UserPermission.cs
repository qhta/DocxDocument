using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface UserPermission: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string UserId { get; }
  int Permission { get; set; }
  object ExpirationDate { get; set; }
  object Parent { get; }
  void Remove();
}