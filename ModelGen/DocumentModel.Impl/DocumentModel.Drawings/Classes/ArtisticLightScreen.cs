namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticLightScreen Class.
/// </summary>
public class ArtisticLightScreenImpl: ModelElementImpl, ArtisticLightScreen
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticLightScreenImpl(): base() {}
  
  public ArtisticLightScreenImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen openXmlElement): base(openXmlElement)
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
  /// gridSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? GridSize
  {
    get => (Int32?)OpenXmlElement?.GridSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GridSize = (System.Int32?)value;
    }
  }
  
}
