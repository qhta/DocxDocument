namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticTexturizer Class.
/// </summary>
public partial class ArtisticTexturizerImpl: ModelElementImpl, ArtisticTexturizer
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticTexturizerImpl(): base() {}
  
  public ArtisticTexturizerImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer openXmlElement): base(openXmlElement)
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
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Scaling
  {
    get => (System.Int32?)OpenXmlElement?.Scaling?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Scaling = (System.Int32?)value;
    }
  }
  
}
