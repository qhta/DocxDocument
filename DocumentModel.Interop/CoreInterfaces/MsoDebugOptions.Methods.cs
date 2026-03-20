
namespace DocumentModel.Interop.Core;

public partial interface MsoDebugOptions
{
  public void AddIgnoredAssertTag(string bstrTagToIgnore);
  public void RemoveIgnoredAssertTag(string bstrTagToIgnore);
}
