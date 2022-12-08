namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPaintBrush Class.
/// </summary>
public class ArtisticPaintBrushImpl: ModelElementImpl, ArtisticPaintBrush
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy
  {
    get;
    set;
  }
  
  /// <summary>
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize
  {
    get;
    set;
  }
  
}
