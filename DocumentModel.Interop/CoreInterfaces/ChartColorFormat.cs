using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ChartColorFormat
{
  public int SchemeColor { get; set; }
  public int RGB { get; set; }
  public int _Default { get; }
  public int Type { get; }
}
