namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticLineDrawing Class.
/// </summary>
public interface IArtisticLineDrawing // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? PencilSize { get ; set; }
  
}
