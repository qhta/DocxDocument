
namespace DocumentModel.Interop.Core;

public interface Axes
{
  int Count { get; }
  IMsoAxis Item { get; }
  object _NewEnum { get; }
  object Application { get; }
  int Creator { get; }
  IMsoAxis this[XlAxisType Type, XlAxisGroup AxisGroup = XlAxisGroup.xlPrimary] { get; }
  object Parent { get; }
}