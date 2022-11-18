namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticLightScreen Class.
/// </summary>
public interface IArtisticLightScreen // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// gridSize, this property is only available in Office 2010 and later.
  /// </summary>
  public int? GridSize { get ; set; }
  
}
