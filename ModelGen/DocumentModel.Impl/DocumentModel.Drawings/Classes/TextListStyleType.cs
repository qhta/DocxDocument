namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextListStyleType Class.
/// </summary>
public class TextListStyleTypeImpl: ModelElementImpl, TextListStyleType
{
  public DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Drawing.Diagram12.TextListStyleType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  public DefaultParagraphProperties? DefaultParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  public Level1ParagraphProperties? Level1ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  public Level2ParagraphProperties? Level2ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  public Level3ParagraphProperties? Level3ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  public Level4ParagraphProperties? Level4ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  public Level5ParagraphProperties? Level5ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  public Level6ParagraphProperties? Level6ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  public Level7ParagraphProperties? Level7ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  public Level8ParagraphProperties? Level8ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  public Level9ParagraphProperties? Level9ParagraphProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
