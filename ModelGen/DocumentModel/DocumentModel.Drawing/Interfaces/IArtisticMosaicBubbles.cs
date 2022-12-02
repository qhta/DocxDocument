namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ArtisticMosaicBubbles Class.
/// </summary>
public interface IArtisticMosaicBubbles // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Pressure { get ; set; }
  
}
