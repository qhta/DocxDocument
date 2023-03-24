namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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