namespace DocumentModel.Presentation;

/// <summary>
/// Default print output
/// </summary>
public enum PrintOutput
{
  /// <summary>
  /// Slides.
  /// </summary>
  [XmlEnum("slides")]
  Slides,
  
  /// <summary>
  /// 1 Slide / Handout Page.
  /// </summary>
  [XmlEnum("handouts1")]
  Handouts1,
  
  /// <summary>
  /// 2 Slides / Handout Page.
  /// </summary>
  [XmlEnum("handouts2")]
  Handouts2,
  
  /// <summary>
  /// 3 Slides / Handout Page.
  /// </summary>
  [XmlEnum("handouts3")]
  Handouts3,
  
  /// <summary>
  /// 4 Slides / Handout Page.
  /// </summary>
  [XmlEnum("handouts4")]
  Handouts4,
  
  /// <summary>
  /// 6 Slides / Handout Page.
  /// </summary>
  [XmlEnum("handouts6")]
  Handouts6,
  
  /// <summary>
  /// 9 Slides / Handout Page.
  /// </summary>
  [XmlEnum("handouts9")]
  Handouts9,
  
  /// <summary>
  /// Notes.
  /// </summary>
  [XmlEnum("notes")]
  Notes,
  
  /// <summary>
  /// Outline.
  /// </summary>
  [XmlEnum("outline")]
  Outline,
  
}
