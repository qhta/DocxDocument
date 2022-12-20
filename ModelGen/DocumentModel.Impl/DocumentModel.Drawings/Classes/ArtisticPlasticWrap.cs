namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPlasticWrap Class.
/// </summary>
public partial class ArtisticPlasticWrapImpl: ModelElementImpl, ArtisticPlasticWrap
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticPlasticWrapImpl(): base() {}
  
  public ArtisticPlasticWrapImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap openXmlElement): base(openXmlElement)
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
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Smoothness
  {
    get => (System.Int32?)OpenXmlElement?.Smoothness?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Smoothness = (System.Int32?)value;
    }
  }
  
}
