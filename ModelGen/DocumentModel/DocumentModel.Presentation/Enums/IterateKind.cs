namespace DocumentModel.Presentation;

/// <summary>
/// Iterate Type
/// </summary>
public enum IterateKind
{
  /// <summary>
  /// Element.
  /// </summary>
  [XmlEnum("el")]
  Element,
  
  /// <summary>
  /// Word.
  /// </summary>
  [XmlEnum("wd")]
  Word,
  
  /// <summary>
  /// Letter.
  /// </summary>
  [XmlEnum("lt")]
  Letter,
  
}
