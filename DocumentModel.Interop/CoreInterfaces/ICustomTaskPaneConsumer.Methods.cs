
namespace DocumentModel.Interop.Core;

public partial interface ICustomTaskPaneConsumer
{
  public void CTPFactoryAvailable(ICTPFactory CTPFactoryInst);
}
