namespace DocumentModel.Drawing;

/// <summary>
/// Reflection Effect.
/// </summary>
public class Reflection: IReflection
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  public long? BlurRadius
  {
    get;
    set;
  }
  
  /// <summary>
  /// Start Opacity
  /// </summary>
  public int? StartOpacity
  {
    get;
    set;
  }
  
  /// <summary>
  /// Start Position
  /// </summary>
  public int? StartPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// End Alpha
  /// </summary>
  public int? EndAlpha
  {
    get;
    set;
  }
  
  /// <summary>
  /// End Position
  /// </summary>
  public int? EndPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance
  /// </summary>
  public long? Distance
  {
    get;
    set;
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public int? Direction
  {
    get;
    set;
  }
  
  /// <summary>
  /// Fade Direction
  /// </summary>
  public int? FadeDirection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public int? HorizontalRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public int? VerticalRatio
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public int? HorizontalSkew
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public int? VerticalSkew
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public DocumentModel.Drawing.RectangleAlignmentValues? Alignment
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public bool? RotateWithShape
  {
    get;
    set;
  }
  
}
