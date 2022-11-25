namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticPlasticWrap Class.
/// </summary>
public interface IArtisticPlasticWrap // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Smoothness { get ; set; }
  
}
