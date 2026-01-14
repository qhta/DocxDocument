namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a set of borders for an HTML div element in a Wordprocessing document.
/// This class provides properties for configuring the top, left, bottom, and right borders, enabling advanced formatting and appearance control for HTML div elements.
/// </summary>
public class DivBorders
{
  
  /// <summary>
  /// Top border for the HTML div, specifying the style and appearance of the top edge.
  /// </summary>
  public Border? TopBorder { get; set; }
  
  /// <summary>
  /// Left border for the HTML div, specifying the style and appearance of the left edge.
  /// </summary>
  public Border? LeftBorder { get; set; }
  
  /// <summary>
  /// Bottom border for the HTML div, specifying the style and appearance of the bottom edge.
  /// </summary>
  public Border? BottomBorder { get; set; }
  
  /// <summary>
  /// Right border for the HTML div, specifying the style and appearance of the right edge.
  /// </summary>
  public Border? RightBorder { get; set; }
}