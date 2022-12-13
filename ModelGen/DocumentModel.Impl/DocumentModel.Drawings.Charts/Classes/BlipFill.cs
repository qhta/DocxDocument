namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Picture Fill.
/// </summary>
public class BlipFillImpl: ModelElementImpl, BlipFill
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BlipFillImpl(): base() {}
  
  public BlipFillImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// DPI Setting
  /// </summary>
  public UInt32? Dpi
  {
    get => (System.UInt32?)OpenXmlElement?.Dpi?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dpi = (System.UInt32?)value;
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
  /// Blip.
  /// </summary>
  public DocumentModel.Drawings.Blip? Blip
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public DocumentModel.Drawings.RelativeRectangleType? SourceRectangle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Tile? Tile
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Stretch? Stretch
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
