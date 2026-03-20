
namespace DocumentModel.Interop.Core;

public interface ConnectorFormat: InteropObject
{
  public void BeginConnect(Shape ConnectedShape, int ConnectionSite);
  public void BeginDisconnect();
  public void EndConnect(Shape ConnectedShape, int ConnectionSite);
  public void EndDisconnect();
  public MsoTriState BeginConnected { get; }
  public Shape BeginConnectedShape { get; }
  public int BeginConnectionSite { get; }
  public MsoTriState EndConnected { get; }
  public Shape EndConnectedShape { get; }
  public int EndConnectionSite { get; }
  public MsoConnectorType Type { get; set; }
}
