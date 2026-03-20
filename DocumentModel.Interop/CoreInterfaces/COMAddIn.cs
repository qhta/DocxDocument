using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface COMAddIn: InteropObject
{
  string Description { get; set; }
  string ProgId { get; }
  string Guid { get; }
  bool Connect { get; set; }
  object Object { get; set; }
}