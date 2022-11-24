namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticBlur Class.
/// </summary>
public interface IArtisticBlur // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// radius, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Radius { get ; set; }
  
}
