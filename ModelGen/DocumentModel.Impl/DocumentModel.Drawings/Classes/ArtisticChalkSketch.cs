namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticChalkSketch Class.
/// </summary>
public partial class ArtisticChalkSketchImpl: ModelElementImpl, ArtisticChalkSketch
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticChalkSketchImpl(): base() {}
  
  public ArtisticChalkSketchImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch openXmlElement): base(openXmlElement)
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
