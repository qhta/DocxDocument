namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticMarker Class.
/// </summary>
public interface IArtisticMarker // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Size { get ; set; }
  
}
