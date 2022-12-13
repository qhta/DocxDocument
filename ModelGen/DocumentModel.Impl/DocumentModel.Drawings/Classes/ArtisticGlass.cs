namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticGlass Class.
/// </summary>
public class ArtisticGlassImpl: ModelElementImpl, ArtisticGlass
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticGlassImpl(): base() {}
  
  public ArtisticGlassImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass openXmlElement): base(openXmlElement)
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
