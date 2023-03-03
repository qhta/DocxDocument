namespace DocumentModel;

/// <summary>
///   Defines the LayoutChildrenValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LayoutChildrenKind
{
  /// <summary>
  ///   horizontal.
  /// </summary>
  Horizontal,

  /// <summary>
  ///   vertical.
  /// </summary>
  Vertical
}