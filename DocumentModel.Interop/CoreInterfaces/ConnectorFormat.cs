
namespace DocumentModel.Interop.Core;

public interface ConnectorFormat: InteropObject
{
  void BeginConnect(Shape ConnectedShape, int ConnectionSite);
  void BeginDisconnect();
  void EndConnect(Shape ConnectedShape, int ConnectionSite);
  void EndDisconnect();
  MsoTriState BeginConnected { get; }
  Shape BeginConnectedShape { get; }
  int BeginConnectionSite { get; }
  MsoTriState EndConnected { get; }
  Shape EndConnectedShape { get; }
  int EndConnectionSite { get; }
  MsoConnectorType Type { get; set; }
}