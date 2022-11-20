namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageBorderOffsetValues enumeration.
/// </summary>
public enum PageBorderOffsetValues
{
  /// <summary>
  /// Page Border Is Positioned Relative to Page Edges.
  /// </summary>
  [XmlEnum("page")]
  Page,
  
  /// <summary>
  /// Page Border Is Positioned Relative to Text Extents.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
}
