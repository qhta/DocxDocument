namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Connection Locations Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConnectKind
{
  /// <summary>
  ///   No.
  /// </summary>
  None,

  /// <summary>
  ///   Four Connections.
  /// </summary>
  IRectangle,

  /// <summary>
  ///   Edit IPoint Connections.
  /// </summary>
  Segments,

  /// <summary>
  ///   Custom Connections.
  /// </summary>
  Custom
}
