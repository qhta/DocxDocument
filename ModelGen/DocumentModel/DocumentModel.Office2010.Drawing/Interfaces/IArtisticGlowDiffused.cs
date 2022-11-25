namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticGlowDiffused Class.
/// </summary>
public interface IArtisticGlowDiffused // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Intensity { get ; set; }
  
}
