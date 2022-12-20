namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public partial class ArtisticCementImpl: ModelElementImpl, ArtisticCement
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticCementImpl(): base() {}
  
  public ArtisticCementImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement openXmlElement): base(openXmlElement)
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
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? CrackSpacing
  {
    get => (System.Int32?)OpenXmlElement?.CrackSpacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CrackSpacing = (System.Int32?)value;
    }
  }
  
}
