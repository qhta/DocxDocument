namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ArtisticChalkSketch Class.
/// </summary>
public interface IArtisticChalkSketch // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure { get ; set; }
  
}
