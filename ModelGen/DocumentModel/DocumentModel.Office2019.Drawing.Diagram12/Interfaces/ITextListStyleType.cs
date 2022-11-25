namespace DocumentModel.Office2019.Drawing.Diagram12;

/// <summary>
/// Defines the TextListStyleType Class.
/// </summary>
public interface ITextListStyleType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? DefaultParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level1ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level2ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level3ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level4ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level5ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level6ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level7ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level8ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  public DocumentModel.Drawing.ITextParagraphPropertiesType? Level9ParagraphProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
