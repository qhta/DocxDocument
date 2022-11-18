namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticPencilGrayscale Class.
/// </summary>
public interface IArtisticPencilGrayscale // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public int? BrushSize { get ; set; }
  
}
