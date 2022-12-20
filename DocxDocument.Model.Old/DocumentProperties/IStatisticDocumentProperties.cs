namespace DocxDocument.Model;

public interface IStatisticDocumentProperties
{
  /// <summary> 
  /// Total time that a document has been edited. The default time unit is minutes.
  ///</summary> 
  public int? TotalTime { get; set; }

  /// <summary> 
  /// This element specifies the total number of characters in a document.
  ///</summary> 
  public int? Characters { get; set; }

  /// <summary> 
  /// This element specifies the last count of the number of characters (including spaces) in this document.
  ///</summary> 
  public int? CharactersWithSpaces { get; set; }

  /// <summary> 
  /// This element specifies the total number of lines in a document when last saved by a conforming producer if applicable.
  ///</summary> 
  public int? Lines { get; set; }

  /// <summary> 
  /// This element specifies the total number of pages of a document if applicable.
  ///</summary> 
  public int? Pages { get; set; }

  /// <summary> 
  /// This element specifies the total number of paragraphs found in a document if applicable.
  ///</summary> 
  public int? Paragraphs { get; set; }

  /// <summary> 
  /// This element specifies the total number of words contained in a document when last saved.
  ///</summary> 
  public int? Words { get; set; }
    
  /// <summary> 
  /// This element specifies the total number of slides in a presentation document.
  ///</summary> 
  public int? Slides { get; set; }

  /// <summary> 
  /// This element specifies the number of hidden slides in a presentation document.
  ///</summary> 
  public int? HiddenSlides { get; set; }

  /// <summary> 
  /// This element specifies the total number of sound or video clips that are present in the document.
  ///</summary> 
  public int? MultimediaClips { get; set; }

  /// <summary> 
  /// This element specifies the number of slides in a presentation containing notes.
  ///</summary> 
  public int? Notes { get; set; }

}