using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ChartColorFormat
{
  object Parent { get; }
  int SchemeColor { get; set; }
  int RGB { get; set; }
  int _Default { get; }
  int Type { get; }
  object Application { get; }
  int Creator { get; }
}