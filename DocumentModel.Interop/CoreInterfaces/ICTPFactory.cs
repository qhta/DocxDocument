
namespace DocumentModel.Interop.Core;

public interface ICTPFactory
{
  CustomTaskPane CreateCTP(string CTPAxID, string CTPTitle, object CTPParentWindow);
}