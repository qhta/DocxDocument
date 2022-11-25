namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticPencilGrayscale Class.
/// </summary>
public interface IArtisticPencilGrayscale // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? BrushSize { get ; set; }
  
}
