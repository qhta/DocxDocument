namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Connector Type
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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