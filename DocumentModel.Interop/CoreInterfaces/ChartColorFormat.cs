using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ChartColorFormat
{
  int SchemeColor { get; set; }
  int RGB { get; set; }
  int _Default { get; }
  int Type { get; }
}