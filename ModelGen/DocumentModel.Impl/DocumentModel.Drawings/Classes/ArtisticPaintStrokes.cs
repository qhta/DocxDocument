namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPaintStrokes Class.
/// </summary>
public partial class ArtisticPaintStrokesImpl: ModelElementImpl, ArtisticPaintStrokes
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticPaintStrokesImpl(): base() {}
  
  public ArtisticPaintStrokesImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes openXmlElement): base(openXmlElement)
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
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Intensity
  {
    get => (System.Int32?)OpenXmlElement?.Intensity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Intensity = (System.Int32?)value;
    }
  }
  
}
