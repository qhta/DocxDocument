namespace DocumentModel.Presentation;

/// <summary>
/// Slide Master Other Text Style.
/// </summary>
public interface OtherStyle // : DocumentModel.Presentation.TextListStyleType
{
  public DocumentModel.Drawings.DefaultParagraphProperties? DefaultParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level1ParagraphProperties? Level1ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level2ParagraphProperties? Level2ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level3ParagraphProperties? Level3ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level4ParagraphProperties? Level4ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level5ParagraphProperties? Level5ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level6ParagraphProperties? Level6ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level7ParagraphProperties? Level7ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level8ParagraphProperties? Level8ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.Level9ParagraphProperties? Level9ParagraphProperties { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
