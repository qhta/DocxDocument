
namespace DocumentModel.Interop.Core;

public partial interface ICTPFactory
{
  public CustomTaskPane CreateCTP(string CTPAxID, string CTPTitle, object CTPParentWindow);
}
