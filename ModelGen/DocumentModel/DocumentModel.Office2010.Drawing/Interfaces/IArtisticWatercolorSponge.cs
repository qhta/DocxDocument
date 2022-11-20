namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticWatercolorSponge Class.
/// </summary>
public interface IArtisticWatercolorSponge // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public int? BrushSize { get ; set; }
  
}
