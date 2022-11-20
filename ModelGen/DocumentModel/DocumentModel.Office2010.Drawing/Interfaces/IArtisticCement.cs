namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public interface IArtisticCement // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  public int? CrackSpacing { get ; set; }
  
}
