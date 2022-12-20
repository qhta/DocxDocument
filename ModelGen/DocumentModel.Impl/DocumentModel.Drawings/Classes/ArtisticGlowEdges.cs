namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticGlowEdges Class.
/// </summary>
public partial class ArtisticGlowEdgesImpl: ModelElementImpl, ArtisticGlowEdges
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
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
