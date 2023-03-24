namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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