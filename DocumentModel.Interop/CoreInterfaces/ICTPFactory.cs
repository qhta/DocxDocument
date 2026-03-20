
namespace DocumentModel.Interop.Core;

public interface ICTPFactory
{
  public CustomTaskPane CreateCTP(string CTPAxID, string CTPTitle, object CTPParentWindow);
}
