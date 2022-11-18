namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SectionMarkValues enumeration.
/// </summary>
public enum SectionMark
{
  /// <summary>
  /// Next Page Section Break.
  /// </summary>
  [XmlEnum("nextPage")]
  NextPage,
  
  /// <summary>
  /// Column Section Break.
  /// </summary>
  [XmlEnum("nextColumn")]
  NextColumn,
  
  /// <summary>
  /// Continuous Section Break.
  /// </summary>
  [XmlEnum("continuous")]
  Continuous,
  
  /// <summary>
  /// Even Page Section Break.
  /// </summary>
  [XmlEnum("evenPage")]
  EvenPage,
  
  /// <summary>
  /// Odd Page Section Break.
  /// </summary>
  [XmlEnum("oddPage")]
  OddPage,
  
}
