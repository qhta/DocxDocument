namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPencilSketch Class.
/// </summary>
public partial class ArtisticPencilSketchImpl: ModelElementImpl, ArtisticPencilSketch
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticPencilSketchImpl(): base() {}
  
  public ArtisticPencilSketchImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch openXmlElement): base(openXmlElement)
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
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure
  {
    get => (System.Int32?)OpenXmlElement?.Pressure?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pressure = (System.Int32?)value;
    }
  }
  
}
