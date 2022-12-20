namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPhotocopy Class.
/// </summary>
public partial class ArtisticPhotocopyImpl: ModelElementImpl, ArtisticPhotocopy
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticPhotocopyImpl(): base() {}
  
  public ArtisticPhotocopyImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPhotocopy openXmlElement): base(openXmlElement)
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
  /// detail, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Detail
  {
    get => (System.Int32?)OpenXmlElement?.Detail?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Detail = (System.Int32?)value;
    }
  }
  
}
