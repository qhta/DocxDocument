namespace DocumentModel.Drawings;
/// <summary>
/// Represents a connection type for connectors, defining an identifier and index for the connection.
/// </summary>
public partial class ConnectionType : ModelElement<DXD.ConnectionType>
{
  /// <summary>
  /// Unique identifier for the connection.
  /// </summary>
  public UInt32? Id { get; set; }
  /// <summary>
  /// Index of the connection.
  /// </summary>
  public UInt32? Index { get; set; }
}