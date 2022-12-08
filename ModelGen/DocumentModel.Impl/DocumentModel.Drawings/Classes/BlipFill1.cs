namespace DocumentModel.Drawings;

/// <summary>
/// Picture Fill.
/// </summary>
public class BlipFill1Impl: ModelElementImpl, BlipFill1
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.BlipFill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// DPI Setting
  /// </summary>
  public UInt32? Dpi
  {
    get;
    set;
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
  /// Blip.
  /// </summary>
  public Blip? Blip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Source Rectangle.
  /// </summary>
  public RelativeRectangleType? SourceRectangle
  {
    get;
    set;
  }
  
  public Tile? Tile
  {
    get;
    set;
  }
  
  public Stretch? Stretch
  {
    get;
    set;
  }
  
}
