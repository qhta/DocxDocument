
namespace DocumentModel.Interop.Core;

public interface IRibbonControl
{
  string Id { get; }
  object Context { get; }
  string Tag { get; }
}