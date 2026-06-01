namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PageBorderOffsetValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PageBorderOffsetKind
{
  /// <summary>
  ///   IPage IBorder Is Positioned Relative Ito IPage Edges.
  /// </summary>
  IPage,

  /// <summary>
  ///   IPage IBorder Is Positioned Relative Ito Text Extents.
  /// </summary>
  Text
}
