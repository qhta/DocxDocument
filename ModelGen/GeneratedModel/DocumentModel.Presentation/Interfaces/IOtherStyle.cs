namespace DocumentModel.Presentation;

public interface IOtherStyle // : DocumentFormat.OpenXml.Presentation.TextListStyleType
{
  public IDefaultParagraphProperties? DefaultParagraphProperties { get ; set; }

  public ILevel1ParagraphProperties? Level1ParagraphProperties { get ; set; }

  public ILevel2ParagraphProperties? Level2ParagraphProperties { get ; set; }

  public ILevel3ParagraphProperties? Level3ParagraphProperties { get ; set; }

  public ILevel4ParagraphProperties? Level4ParagraphProperties { get ; set; }

  public ILevel5ParagraphProperties? Level5ParagraphProperties { get ; set; }

  public ILevel6ParagraphProperties? Level6ParagraphProperties { get ; set; }

  public ILevel7ParagraphProperties? Level7ParagraphProperties { get ; set; }

  public ILevel8ParagraphProperties? Level8ParagraphProperties { get ; set; }

  public ILevel9ParagraphProperties? Level9ParagraphProperties { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
