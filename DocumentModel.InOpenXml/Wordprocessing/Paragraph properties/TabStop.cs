namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a custom tab stop in a paragraph for WordprocessingML documents.
/// This class extends <see cref="CollectionItem"/> and provides properties for tab stop type, leader character, and position, enabling advanced control over tab alignment and formatting within paragraphs.
/// </summary>
public class TabStop: ModelElement<DXW.TabStop>
{
  
  /// <summary>
  /// Type of the tab stop, specifying the alignment (e.g., left, center, right, decimal, bar).
  /// </summary>
  public TabStopKind? Val { get; set; }
  
  /// <summary>
  /// Leader character for the tab stop, specifying the character used to fill the space advanced by the tab (e.g., dots, dashes, underline).
  /// </summary>
  public TabStopLeaderCharKind? Leader { get; set; }
  
  /// <summary>
  /// Position of the tab stop, specified in twentieths of a point from the paragraph's left margin.
  /// </summary>
  public Int32? Position { get; set; }
}