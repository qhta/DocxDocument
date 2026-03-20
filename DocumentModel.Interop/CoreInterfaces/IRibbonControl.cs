
namespace DocumentModel.Interop.Core;

public partial interface IRibbonControl
{
  public string Id { get; }
  public object Context { get; }
  public string Tag { get; }
}
