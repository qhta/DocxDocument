
namespace DocumentModel.Interop.Core;

public partial interface ConnectorFormat: InteropObject
{
  public MsoTriState BeginConnected { get; }
  public Shape BeginConnectedShape { get; }
  public int BeginConnectionSite { get; }
  public MsoTriState EndConnected { get; }
  public Shape EndConnectedShape { get; }
  public int EndConnectionSite { get; }
  public MsoConnectorType Type { get; set; }
}
