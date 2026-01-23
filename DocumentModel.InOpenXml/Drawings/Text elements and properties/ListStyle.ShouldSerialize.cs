namespace DocumentModel.Drawings;

public partial class ListStyle
{
  public bool ShouldSerializeDefaultParagraphProperties() => DefaultParagraphProperties is not null;
  public bool ShouldSerializeLevel1ParagraphProperties() => Level1ParagraphProperties is not null;
  public bool ShouldSerializeLevel2ParagraphProperties() => Level2ParagraphProperties is not null;
  public bool ShouldSerializeLevel3ParagraphProperties() => Level3ParagraphProperties is not null;
  public bool ShouldSerializeLevel4ParagraphProperties() => Level4ParagraphProperties is not null;
  public bool ShouldSerializeLevel5ParagraphProperties() => Level5ParagraphProperties is not null;
  public bool ShouldSerializeLevel6ParagraphProperties() => Level6ParagraphProperties is not null;
  public bool ShouldSerializeLevel7ParagraphProperties() => Level7ParagraphProperties is not null;
  public bool ShouldSerializeLevel8ParagraphProperties() => Level8ParagraphProperties is not null;
  public bool ShouldSerializeLevel9ParagraphProperties() => Level9ParagraphProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
