namespace DocxDocument.Model;

/// <summary>
/// Common base class for RunBorders and PageBorders.
/// </summary>
public class FrameBorders
{
  /// <summary> 
  /// Returns or sets border formatting for the specified object.
  ///</summary> 
  public bool? Enable { get; set; }

  /// <summary> 
  /// Returns or sets the space (in points) between the text (or page) and the bottom border.
  ///</summary> 
  public float? DistanceFromBottom { get; set; }

  /// <summary> 
  /// Returns or sets the space (in points) between the text (or page) and the left border.
  ///</summary> 
  public float? DistanceFromLeft { get; set; }

  /// <summary> 
  /// Returns or sets the space (in points) between the text (or page) and the right border.
  ///</summary> 
  public float? DistanceFromRight { get; set; }

  /// <summary> 
  /// Returns or sets the space (in points) between the text (or page) and the top border.
  ///</summary> 
  public float? DistanceFromTop { get; set; }

  /// <summary> 
  /// True if a horizontal border can be applied to the object.
  ///</summary> 
  public bool HasHorizontal { get; set; }

  /// <summary> 
  /// True if a vertical border can be applied to the specified object.
  ///</summary> 
  public bool HasVertical { get; set; }

  /// <summary> 
  /// Returns or sets the 24-bit color of the inside borders.
  ///</summary> 
  public Color? InsideColor { get; set; }

  /// <summary> 
  /// Returns or sets the color of the inside borders.
  ///</summary> 
  public ColorIndex? InsideColorIndex { get; set; }

  /// <summary> 
  /// Returns or sets the inside border for the specified object.
  ///</summary> 
  public LineStyle? InsideLineStyle { get; set; }

  /// <summary> 
  /// Returns or sets the line width of the inside border of an object.
  ///</summary> 
  public LineWidth? InsideLineWidth { get; set; }

  /// <summary> 
  /// True if vertical borders at the edges of paragraphs and tables are removed so that the horizontal borders can connect to the page border
  ///</summary> 
  public bool? JoinBorders { get; set; }

  /// <summary> 
  /// Returns or sets the 24-bit color of the outside borders.
  ///</summary> 
  public Color? OutsideColor { get; set; }

  /// <summary> 
  /// Returns or sets the color of the outside borders.
  ///</summary> 
  public ColorIndex? OutsideColorIndex { get; set; }

  /// <summary> 
  /// Returns or sets the outside border for the specified object.
  ///</summary> 
  public LineStyle? OutsideLineStyle { get; set; }

  /// <summary> 
  /// Returns or sets the line width of the outside border of an object.
  ///</summary> 
  public LineWidth? OutsideLineWidth { get; set; }

  /// <summary> 
  /// True if the specified border is formatted as shadowed
  ///</summary> 
  public bool? Shadow { get; set; }

}