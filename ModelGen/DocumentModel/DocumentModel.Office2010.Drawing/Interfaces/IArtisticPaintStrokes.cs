namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticPaintStrokes Class.
/// </summary>
public interface IArtisticPaintStrokes // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Intensity { get ; set; }
  
}
