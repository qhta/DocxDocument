namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GradientFill Class.
/// </summary>
public class GradientFillImpl: ModelElement<DocumentFormat.OpenXml.Drawing.GradientFill>, GradientFill
{
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
  
}
