namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ArtisticLightScreen Class.
/// </summary>
public interface IArtisticLightScreen // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// gridSize, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? GridSize { get ; set; }
  
}
