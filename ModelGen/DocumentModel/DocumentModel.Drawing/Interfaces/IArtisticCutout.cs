namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ArtisticCutout Class.
/// </summary>
public interface IArtisticCutout // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? NumberOfShades { get ; set; }
  
}
