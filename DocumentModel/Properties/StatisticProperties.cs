namespace DocumentModel;

/// <summary>
///   Application Specific File Properties.
/// </summary>
public partial record StatisticProperties: KnownDocumentProperties
{
  /// <summary>
  ///   Total Number of Pages.
  /// </summary>
  public int? Pages { get; set; }

  /// <summary>
  ///   Word Count.
  /// </summary>
  public int? Words { get; set; }

  /// <summary>
  ///   Total Number of Characters.
  /// </summary>
  public int? Characters { get; set; }

  /// <summary>
  ///   Number of Lines.
  /// </summary>
  public int? Lines { get; set; }

  /// <summary>
  ///   Total Number of Paragraphs.
  /// </summary>
  public int? Paragraphs { get; set; }

  /// <summary>
  ///   Number of Characters (With Spaces).
  /// </summary>
  public int? CharactersWithSpaces { get; set; }

  /// <summary>
  ///   Slides Metadata Element.
  /// </summary>
  public int? Slides { get; set; }
  
  /// <summary>
  ///   Number of Slides Containing Notes.
  /// </summary>
  public int? Notes { get; set; }
  
  /// <summary>
  ///   Number of Hidden Slides.
  /// </summary>
  public int? HiddenSlides { get; set; }

  /// <summary>
  ///   Total Number of Multimedia Clips.
  /// </summary>
  public int? MultimediaClips { get; set; }

  /// <summary>
  ///   Total Edit Time Metadata Element.
  /// </summary>
  public int? TotalTime { get; set; }
}