namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalTextAlignmentValues enumeration.
/// </summary>
public enum VerticalTextAlignment
{
  /// <summary>
  /// Align Text at Top.
  /// </summary>
  [XmlEnum("top")]
  Top,
  
  /// <summary>
  /// Align Text at Center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// Align Text at Baseline.
  /// </summary>
  [XmlEnum("baseline")]
  Baseline,
  
  /// <summary>
  /// Align Text at Bottom.
  /// </summary>
  [XmlEnum("bottom")]
  Bottom,
  
  /// <summary>
  /// Automatically Determine Alignment.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
}
