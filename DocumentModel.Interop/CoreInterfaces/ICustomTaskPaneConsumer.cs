
namespace DocumentModel.Interop.Core;

public interface ICustomTaskPaneConsumer
{
  void CTPFactoryAvailable(ICTPFactory CTPFactoryInst);
}