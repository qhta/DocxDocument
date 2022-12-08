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
  
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy
  {
    get;
    set;
  }
  
  /// <summary>
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize
  {
    get;
    set;
  }
  
}
