namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticMosaicBubbles Class.
/// </summary>
public interface IArtisticMosaicBubbles // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Pressure { get ; set; }
  
}
