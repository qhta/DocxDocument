namespace DocumentModel.UI;

/// <summary>
///   Defines the BoxStyleValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BoxStyleKind
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