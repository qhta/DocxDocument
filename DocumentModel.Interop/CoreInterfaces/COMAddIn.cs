using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface COMAddIn: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Description { get; set; }
  string ProgId { get; }
  string Guid { get; }
  bool Connect { get; set; }
  object Object { get; set; }
  object Parent { get; }
}