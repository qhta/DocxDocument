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
  Rectangle,

  /// <summary>
  ///   Edit Point Connections.
  /// </summary>
  Segments,

  /// <summary>
  ///   Custom Connections.
  /// </summary>
  Custom
}