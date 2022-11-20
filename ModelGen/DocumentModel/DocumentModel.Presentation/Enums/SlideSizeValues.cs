namespace DocumentModel.Presentation;

/// <summary>
/// Slide Size Type
/// </summary>
public enum SlideSizeValues
{
  /// <summary>
  /// Screen 4x3.
  /// </summary>
  [XmlEnum("screen4x3")]
  Screen4x3,
  
  /// <summary>
  /// Letter.
  /// </summary>
  [XmlEnum("letter")]
  Letter,
  
  /// <summary>
  /// A4.
  /// </summary>
  [XmlEnum("A4")]
  A4,
  
  /// <summary>
  /// 35mm Film.
  /// </summary>
  [XmlEnum("35mm")]
  Film35mm,
  
  /// <summary>
  /// Overhead.
  /// </summary>
  [XmlEnum("overhead")]
  Overhead,
  
  /// <summary>
  /// Banner.
  /// </summary>
  [XmlEnum("banner")]
  Banner,
  
  /// <summary>
  /// Custom.
  /// </summary>
  [XmlEnum("custom")]
  Custom,
  
  /// <summary>
  /// Ledger.
  /// </summary>
  [XmlEnum("ledger")]
  Ledger,
  
  /// <summary>
  /// A3.
  /// </summary>
  [XmlEnum("A3")]
  A3,
  
  /// <summary>
  /// B4ISO.
  /// </summary>
  [XmlEnum("B4ISO")]
  B4ISO,
  
  /// <summary>
  /// B5ISO.
  /// </summary>
  [XmlEnum("B5ISO")]
  B5ISO,
  
  /// <summary>
  /// B4JIS.
  /// </summary>
  [XmlEnum("B4JIS")]
  B4JIS,
  
  /// <summary>
  /// B5JIS.
  /// </summary>
  [XmlEnum("B5JIS")]
  B5JIS,
  
  /// <summary>
  /// Hagaki Card.
  /// </summary>
  [XmlEnum("hagakiCard")]
  HagakiCard,
  
  /// <summary>
  /// Screen 16x9.
  /// </summary>
  [XmlEnum("screen16x9")]
  Screen16x9,
  
  /// <summary>
  /// Screen 16x10.
  /// </summary>
  [XmlEnum("screen16x10")]
  Screen16x10,
  
}
