namespace DocumentModel.Office2019.Drawing.Diagram12;

/// <summary>
/// Defines the TextListStyleType Class.
/// </summary>
public interface ITextListStyleType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  public DocumentModel.Drawing.IDefaultParagraphProperties? DefaultParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel1ParagraphProperties? Level1ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel2ParagraphProperties? Level2ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel3ParagraphProperties? Level3ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel4ParagraphProperties? Level4ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel5ParagraphProperties? Level5ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel6ParagraphProperties? Level6ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel7ParagraphProperties? Level7ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel8ParagraphProperties? Level8ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ILevel9ParagraphProperties? Level9ParagraphProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
