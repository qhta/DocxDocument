namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public class GradientFillImpl: ModelElementImpl, GradientFill
{
  public DocumentFormat.OpenXml.Drawing.GradientFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GradientFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Tile Flip
  /// </summary>
  public TileFlipKind? Flip
  {
    get => (TileFlipKind?)OpenXmlElement?.Flip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Flip = (DocumentFormat.OpenXml.Drawing.TileFlipValues?)value;
    }
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public GradientStopList? GradientStopList
  {
    get;
    set;
  }
  
  public LinearGradientFill? LinearGradientFill
  {
    get;
    set;
  }
  
  public PathGradientFill? PathGradientFill
  {
    get;
    set;
  }
  
  public RelativeRectangleType? TileRectangle
  {
    get;
    set;
  }
  
}
