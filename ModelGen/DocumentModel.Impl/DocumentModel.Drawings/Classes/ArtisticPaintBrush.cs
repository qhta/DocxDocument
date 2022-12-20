namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPaintBrush Class.
/// </summary>
public partial class ArtisticPaintBrushImpl: ModelElementImpl, ArtisticPaintBrush
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticPaintBrushImpl(): base() {}
  
  public ArtisticPaintBrushImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintBrush openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy
  {
    get => (System.Int32?)OpenXmlElement?.Transparancy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Transparancy = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize
  {
    get => (System.Int32?)OpenXmlElement?.BrushSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BrushSize = (System.Int32?)value;
    }
  }
  
}
