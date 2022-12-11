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
  
  public GradientFillImpl(): base() {}
  
  public GradientFillImpl(DocumentFormat.OpenXml.Drawing.GradientFill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
    get => (Boolean?)OpenXmlElement?.RotateWithShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RotateWithShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public GradientStopList? GradientStopList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LinearGradientFill? LinearGradientFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PathGradientFill? PathGradientFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public RelativeRectangleType? TileRectangle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
