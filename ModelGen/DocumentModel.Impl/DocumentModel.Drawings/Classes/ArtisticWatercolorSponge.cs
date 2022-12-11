namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticWatercolorSponge Class.
/// </summary>
public class ArtisticWatercolorSpongeImpl: ModelElementImpl, ArtisticWatercolorSponge
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticWatercolorSpongeImpl(): base() {}
  
  public ArtisticWatercolorSpongeImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticWatercolorSponge openXmlElement): base(openXmlElement)
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
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize
  {
    get => (Int32?)OpenXmlElement?.BrushSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BrushSize = (System.Int32?)value;
    }
  }
  
}
