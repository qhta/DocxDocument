namespace DocumentModel.Drawing;

/// <summary>
/// Reflection Effect.
/// </summary>
public interface IReflection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Blur Radius
  /// </summary>
  public System.Int64? BlurRadius { get ; set; }
  
  /// <summary>
  /// Start Opacity
  /// </summary>
  public System.Int32? StartOpacity { get ; set; }
  
  /// <summary>
  /// Start Position
  /// </summary>
  public System.Int32? StartPosition { get ; set; }
  
  /// <summary>
  /// End Alpha
  /// </summary>
  public System.Int32? EndAlpha { get ; set; }
  
  /// <summary>
  /// End Position
  /// </summary>
  public System.Int32? EndPosition { get ; set; }
  
  /// <summary>
  /// Distance
  /// </summary>
  public System.Int64? Distance { get ; set; }
  
  /// <summary>
  /// Direction
  /// </summary>
  public System.Int32? Direction { get ; set; }
  
  /// <summary>
  /// Fade Direction
  /// </summary>
  public System.Int32? FadeDirection { get ; set; }
  
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public System.Int32? HorizontalRatio { get ; set; }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public System.Int32? VerticalRatio { get ; set; }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public System.Int32? HorizontalSkew { get ; set; }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public System.Int32? VerticalSkew { get ; set; }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public DocumentModel.Drawing.RectangleAlignmentKind? Alignment { get ; set; }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public System.Boolean? RotateWithShape { get ; set; }
  
}
