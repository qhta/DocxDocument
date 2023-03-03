namespace DocumentModel.Vml;

/// <summary>
///   Connector Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConnectorKind
{
  /// <summary>
  ///   No Connector.
  /// </summary>
  None,

  /// <summary>
  ///   Straight Connector.
  /// </summary>
  Straight,

  /// <summary>
  ///   Elbow Connector.
  /// </summary>
  Elbow,

  /// <summary>
  ///   Curved Connector.
  /// </summary>
  Curved
}