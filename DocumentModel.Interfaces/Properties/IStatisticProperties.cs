namespace DocumentModel;
/// <summary>
///   This set of properties is evaluated on document change.
/// </summary>
public interface IStatisticProperties: IModelElement, IDocumentProperties
{
  /// <summary>
  ///   The total number of pages of a document if applicable.
  /// </summary>
  public int? Pages { get; set; }
  /// <summary>
  ///   The total number of words of a document if applicable.
  /// </summary>
  public int? Words { get; set; }
  /// <summary>
  ///   The total number of characters in a document.
  /// </summary>
  public int? Characters { get; set; }
  /// <summary>
  ///   The total number of lines in a document when last saved by a conforming producer if applicable.
  /// </summary>
  public int? Lines { get; set; }
  /// <summary>
  ///   The total number of paragraphs found in a document if applicable.
  /// </summary>
  public int? Paragraphs { get; set; }
  /// <summary>
  ///   The last count of the number of characters (including spaces) in this document.
  /// </summary>
  public int? CharactersWithSpaces { get; set; }
  /// <summary>
  ///  The total number of slides in a presentation document.
  /// </summary>
  public int? Slides { get; set; }
  
  /// <summary>
  ///  The number of slides in a presentation containing notes.
  /// </summary>
  public int? Notes { get; set; }
  
  /// <summary>
  ///   The number of hidden slides in a presentation document.
  /// </summary>
  public int? HiddenSlides { get; set; }
  /// <summary>
  ///   The total number of sound or video clips that are present in the document.
  /// </summary>
  public int? MultimediaClips { get; set; }
  /// <summary>
  ///   Total time that a document has been edited. The default time unit is minutes.
  /// </summary>
  public int? TotalTime { get; set; }
}