namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageBorderOffsetValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageBorderOffsetKind
{
  /// <summary>
  ///   Page Border Is Positioned Relative to Page Edges.
  /// </summary>
  Page,

  /// <summary>
  ///   Page Border Is Positioned Relative to Text Extents.
  /// </summary>
  Text
}