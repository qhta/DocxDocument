using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface COMAddIn: InteropObject
{
  public string Description { get; set; }
  public string ProgId { get; }
  public string Guid { get; }
  public bool Connect { get; set; }
  public object Object { get; set; }
}
