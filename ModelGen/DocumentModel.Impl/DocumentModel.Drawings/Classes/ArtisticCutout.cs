namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticCutout Class.
/// </summary>
public class ArtisticCutoutImpl: ModelElementImpl, ArtisticCutout
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticCutoutImpl(): base() {}
  
  public ArtisticCutoutImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy
  {
    get => (Int32?)OpenXmlElement?.Transparancy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Transparancy = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? NumberOfShades
  {
    get => (Int32?)OpenXmlElement?.NumberOfShades?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberOfShades = (System.Int32?)value;
    }
  }
  
}
