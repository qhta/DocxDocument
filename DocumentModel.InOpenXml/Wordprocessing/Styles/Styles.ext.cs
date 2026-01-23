namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents extended style collection information for a Wordprocessing document.
/// This class provides access to all styles, paragraph styles, character styles, table styles, and numbering styles, enabling advanced querying and management of style collections.
/// </summary>
public partial interface Styles
{
  
  /// <summary>
  /// Collection of all styles including defined in the document
  /// and built-in styles.
  /// </summary>
  public IEnumerable<Style> AllStyles { get; }

  /// <summary>
  /// Collection of all paragraph styles.
  /// </summary>
  public IEnumerable<Style> ParagraphStyles { get; }


  /// <summary>
  /// Collection of all character styles.
  /// </summary>
  public IEnumerable<Style> CharacterStyles { get; }


  /// <summary>
  /// Collection of all table styles.
  /// </summary>
  public IEnumerable<Style> TableStyles { get; }


  /// <summary>
  /// Collection of all numbering styles.
  /// </summary>
  public IEnumerable<Style> NumberingStyles { get; }
}