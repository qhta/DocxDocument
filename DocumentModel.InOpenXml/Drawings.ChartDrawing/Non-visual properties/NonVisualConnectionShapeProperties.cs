namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a connection shape in chart drawings, including shape locks and connection endpoints.
/// </summary>
[OpenXmlType(typeof(DXDCD.NonVisualConnectionShapeProperties))]
public class
  NonVisualConnectionShapeProperties: ModelElement<DXDCD.NonVisualConnectionShapeProperties> //, IExtendableElement
{
  /// <summary>
  /// Specifies locking options that restrict editing or manipulation of the connection shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualConnectionShapeProperties.ConnectionShapeLocks))]
  public ConnectionShapeLocks? ConnectionShapeLocks
  {
    get => _ConnectionShapeLocks;
    set => UpdateField(ref _ConnectionShapeLocks, value, nameof(ConnectionShapeLocks));
  }

  private ConnectionShapeLocks? _ConnectionShapeLocks;

  /// <summary>
  /// Defines the starting connection point for the connection shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualConnectionShapeProperties.StartConnection))]
  public ConnectionType? StartConnection
  {
    get => _StartConnection;
    set => UpdateField(ref _StartConnection, value, nameof(StartConnection));
  }

  private ConnectionType? _StartConnection;

  /// <summary>
  /// Defines the ending connection point for the connection shape.
  /// </summary>
  [OpenXmlProperty(nameof(DXDCD.NonVisualConnectionShapeProperties.EndConnection))]
  public ConnectionType? EndConnection
  {
    get => _EndConnection;
    set => UpdateField(ref _EndConnection, value, nameof(EndConnection));
  }

  private ConnectionType? _EndConnection;
}