namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticGlowEdges Class.
/// </summary>
public class ArtisticGlowEdgesImpl: ModelElementImpl, ArtisticGlowEdges
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticGlowEdgesImpl(): base() {}
  
  public ArtisticGlowEdgesImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges openXmlElement): base(openXmlElement)
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
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Smoothness
  {
    get => (Int32?)OpenXmlElement?.Smoothness?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Smoothness = (System.Int32?)value;
    }
  }
  
}
