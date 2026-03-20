
namespace DocumentModel.Interop.Core;

public interface IRibbonControl
{
  public string Id { get; }
  public object Context { get; }
  public string Tag { get; }
}
