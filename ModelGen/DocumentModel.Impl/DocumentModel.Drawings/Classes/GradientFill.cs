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
  public DocumentModel.Drawings.TileFlipKind? Flip
  {
    get => (DocumentModel.Drawings.TileFlipKind?)OpenXmlElement?.Flip?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.RotateWithShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RotateWithShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Gradient Stop List.
  /// </summary>
  public DocumentModel.Drawings.GradientStopList? GradientStopList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.LinearGradientFill? LinearGradientFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.PathGradientFill? PathGradientFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.RelativeRectangleType? TileRectangle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
