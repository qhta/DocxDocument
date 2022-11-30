namespace DocumentModel.Presentation;

/// <summary>
/// Defines the NotesStyle Class.
/// </summary>
public interface INotesStyle // : DocumentModel.Presentation.ITextListStyleType
{
  public DocumentModel.Drawing.IDefaultParagraphProperties? DefaultParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel1ParagraphProperties? Level1ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel2ParagraphProperties? Level2ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel3ParagraphProperties? Level3ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel4ParagraphProperties? Level4ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel5ParagraphProperties? Level5ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel6ParagraphProperties? Level6ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel7ParagraphProperties? Level7ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel8ParagraphProperties? Level8ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.ILevel9ParagraphProperties? Level9ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
