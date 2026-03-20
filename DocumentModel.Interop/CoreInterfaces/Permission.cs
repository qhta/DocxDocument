using System.Collections;

namespace DocumentModel.Interop.Core;

public interface Permission: InteropObject, IEnumerable
{
  UserPermission this[object Index] { get; }
  int Count { get; }
  bool EnableTrustedBrowser { get; set; }
  UserPermission Add(string UserId, object Permission, object ExpirationDate);
  void ApplyPolicy(string FileName);
  void RemoveAll();
  bool Enabled { get; set; }
  string RequestPermissionURL { get; set; }
  string PolicyName { get; }
  string PolicyDescription { get; }
  bool StoreLicenses { get; set; }
  string DocumentAuthor { get; set; }
  bool PermissionFromPolicy { get; }
  new IEnumerator GetEnumerator();
}