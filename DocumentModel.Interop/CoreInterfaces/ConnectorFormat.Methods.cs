
namespace DocumentModel.Interop.Core;

public partial interface ConnectorFormat
{
  public void BeginConnect(Shape ConnectedShape, int ConnectionSite);
  public void BeginDisconnect();
  public void EndConnect(Shape ConnectedShape, int ConnectionSite);
  public void EndDisconnect();
}
