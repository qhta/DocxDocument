namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public partial interface Styles: IModelElement
{
  /// <summary>
  /// Defines Styles.
  /// </summary>
  public DefinedStyles DefinedStyles { get; set; }
  [XmlIgnore]
  public IEnumerable<Style> AllStyles { get; set; }
  [XmlIgnore]
  public IEnumerable<Style> ParagraphStyles { get; set; }
  [XmlIgnore]
  public IEnumerable<Style> CharacterStyles { get; set; }
  [XmlIgnore]
  public IEnumerable<Style> TableStyles { get; set; }
  [XmlIgnore]
  public IEnumerable<Style> NumberingStyles { get; set; }

}