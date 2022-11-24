namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticWatercolorSponge Class.
/// </summary>
public interface IArtisticWatercolorSponge // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize { get ; set; }
  
}
