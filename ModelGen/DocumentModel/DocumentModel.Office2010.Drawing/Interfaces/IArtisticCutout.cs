namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticCutout Class.
/// </summary>
public interface IArtisticCutout // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  public int? NumberOfShades { get ; set; }
  
}
