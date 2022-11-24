namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public interface IArtisticCement // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? CrackSpacing { get ; set; }
  
}
