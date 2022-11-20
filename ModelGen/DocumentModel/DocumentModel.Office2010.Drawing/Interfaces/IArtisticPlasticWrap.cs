namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticPlasticWrap Class.
/// </summary>
public interface IArtisticPlasticWrap // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Smoothness { get ; set; }
  
}
