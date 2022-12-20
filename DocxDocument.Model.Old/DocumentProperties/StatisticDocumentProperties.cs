namespace DocxDocument.Model;

public class StatisticDocumentProperties: IStatisticDocumentProperties
{
  public StatisticDocumentProperties(XP.Properties docxProperties)
  {
    DocxProperties = docxProperties;
  }

  public XP.Properties DocxProperties { get; set; }

  /// <summary> 
  /// Total time that a document has been edited. The default time unit is minutes.
  ///</summary> 
  public int? TotalTime
  {
    get => DocxRead.ReadInteger(DocxProperties.TotalTime); 
    set => DocxProperties.TotalTime = (value != null) ? new XP.TotalTime { Text = value.ToString()} : null;
  }

  /// <summary> 
  /// This element specifies the total number of characters in a document.
  ///</summary> 
  public int? Characters
  {
    get => DocxRead.ReadInteger(DocxProperties.Characters);
    set => DocxProperties.Characters = (value != null) ? new XP.Characters { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the last count of the number of characters (including spaces) in this document.
  ///</summary> 
  public int? CharactersWithSpaces
  {
    get => DocxRead.ReadInteger(DocxProperties.CharactersWithSpaces);
    set => DocxProperties.CharactersWithSpaces = (value != null) ? new XP.CharactersWithSpaces { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the total number of lines in a document when last saved by a conforming producer if applicable.
  ///</summary> 
  public int? Lines
  {
    get => DocxRead.ReadInteger(DocxProperties.Lines);
    set => DocxProperties.Lines = (value != null) ? new XP.Lines { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the total number of pages of a document if applicable.
  ///</summary> 
  public int? Pages
  {
    get => DocxRead.ReadInteger(DocxProperties.Pages);
    set => DocxProperties.Pages = (value != null) ? new XP.Pages { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the total number of paragraphs found in a document if applicable.
  ///</summary> 
  public int? Paragraphs
  {
    get => DocxRead.ReadInteger(DocxProperties.Paragraphs);
    set => DocxProperties.Paragraphs = (value != null) ? new XP.Paragraphs { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the total number of words contained in a document when last saved.
  ///</summary> 
  public int? Words
  {
    get => DocxRead.ReadInteger(DocxProperties.Words);
    set => DocxProperties.Words = (value != null) ? new XP.Words { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the total number of slides in a presentation document.
  ///</summary> 
  public int? Slides
  {
    get => DocxRead.ReadInteger(DocxProperties.Slides);
    set => DocxProperties.Slides = (value != null) ? new XP.Slides { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the number of hidden slides in a presentation document.
  ///</summary> 
  public int? HiddenSlides
  {
    get => DocxRead.ReadInteger(DocxProperties.HiddenSlides);
    set => DocxProperties.HiddenSlides = (value != null) ? new XP.HiddenSlides { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the total number of sound or video clips that are present in the document.
  ///</summary> 
  public int? MultimediaClips
  {
    get => DocxRead.ReadInteger(DocxProperties.MultimediaClips);
    set => DocxProperties.MultimediaClips = (value != null) ? new XP.MultimediaClips { Text = value.ToString() } : null;
  }

  /// <summary> 
  /// This element specifies the number of slides in a presentation containing notes.
  ///</summary> 
  public int? Notes
  {
    get => DocxRead.ReadInteger(DocxProperties.Notes);
    set => DocxProperties.Notes = (value != null) ? new XP.Notes { Text = value.ToString() } : null;
  }

}