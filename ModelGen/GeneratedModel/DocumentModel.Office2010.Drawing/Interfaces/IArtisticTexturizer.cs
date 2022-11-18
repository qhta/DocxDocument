namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticTexturizer Class.
/// </summary>
public interface IArtisticTexturizer // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Scaling { get ; set; }
  
}
