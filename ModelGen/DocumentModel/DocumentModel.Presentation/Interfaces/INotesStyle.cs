namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesStyle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IDefaultParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel1ParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel2ParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel3ParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel4ParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel5ParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel6ParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel7ParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel8ParagraphProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ILevel9ParagraphProperties))]
public interface INotesStyle // : DocumentFormat.OpenXml.Presentation.TextListStyleType
{
  /// <summary>
  /// Default Paragraph Style.
  /// </summary>
  public IDefaultParagraphProperties? DefaultParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 1 Text Style.
  /// </summary>
  public ILevel1ParagraphProperties? Level1ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 2 Text Style.
  /// </summary>
  public ILevel2ParagraphProperties? Level2ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 3 Text Style.
  /// </summary>
  public ILevel3ParagraphProperties? Level3ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 4 Text Style.
  /// </summary>
  public ILevel4ParagraphProperties? Level4ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 5 Text Style.
  /// </summary>
  public ILevel5ParagraphProperties? Level5ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 6 Text Style.
  /// </summary>
  public ILevel6ParagraphProperties? Level6ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 7 Text Style.
  /// </summary>
  public ILevel7ParagraphProperties? Level7ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 8 Text Style.
  /// </summary>
  public ILevel8ParagraphProperties? Level8ParagraphProperties { get ; set; }
  
  /// <summary>
  /// List Level 9 Text Style.
  /// </summary>
  public ILevel9ParagraphProperties? Level9ParagraphProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
