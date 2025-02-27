namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticFilmGrain Class.
/// </summary>
public partial class ArtisticFilmGrainImpl: ModelElementImpl, ArtisticFilmGrain
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticFilmGrainImpl(): base() {}
  
  public ArtisticFilmGrainImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain openXmlElement): base(openXmlElement)
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
  /// grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? GrainSize
  {
    get => (System.Int32?)OpenXmlElement?.GrainSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GrainSize = (System.Int32?)value;
    }
  }
  
}
