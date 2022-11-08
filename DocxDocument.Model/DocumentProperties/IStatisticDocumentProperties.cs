#nullable enable

namespace DocxDocument.Model;

public interface IStatisticDocumentProperties
{
  /// <summary> 
  /// Total time that a document has been edited. The default time unit is minutes.
  ///</summary> 
  int? TotalTime { get; set; }

  /// <summary> 
  /// This element specifies the total number of characters in a document.
  ///</summary> 
  int? Characters { get; set; }

  /// <summary> 
  /// This element specifies the last count of the number of characters (including spaces) in this document.
  ///</summary> 
  int? CharactersWithSpaces { get; set; }

  /// <summary> 
  /// This element specifies the total number of lines in a document when last saved by a conforming producer if applicable.
  ///</summary> 
  int? Lines { get; set; }

  /// <summary> 
  /// This element specifies the total number of pages of a document if applicable.
  ///</summary> 
  int? Pages { get; set; }

  /// <summary> 
  /// This element specifies the total number of paragraphs found in a document if applicable.
  ///</summary> 
  int? Paragraphs { get; set; }

  /// <summary> 
  /// This element specifies the total number of words contained in a document when last saved.
  ///</summary> 
  int? Words { get; set; }
    
  /// <summary> 
  /// This element specifies the total number of slides in a presentation document.
  ///</summary> 
  int? Slides { get; set; }

  /// <summary> 
  /// This element specifies the number of hidden slides in a presentation document.
  ///</summary> 
  int? HiddenSlides { get; set; }

  /// <summary> 
  /// This element specifies the total number of sound or video clips that are present in the document.
  ///</summary> 
  int? MultimediaClips { get; set; }

  /// <summary> 
  /// This element specifies the number of slides in a presentation containing notes.
  ///</summary> 
  int? Notes { get; set; }

}