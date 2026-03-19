
namespace DocumentModel.Interop.Core;

public interface IMsoBorder
{
  object Color { get; set; }
  object ColorIndex { get; set; }
  object LineStyle { get; set; }
  object Weight { get; set; }
  object Application { get; }
  int Creator { get; }
  object Parent { get; }
}