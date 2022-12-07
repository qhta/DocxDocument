namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Defines the NonVisualGraphicFrameDrawingProperties Class.
/// </summary>
public class NonVisualGraphicFrameDrawingPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Wordprocessing.NonVisualGraphicFrameDrawingProperties>, NonVisualGraphicFrameDrawingProperties
{
  /// <summary>
  /// Graphic Frame Locks.
  /// </summary>
  public DocumentModel.Drawings.GraphicFrameLocks? GraphicFrameLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
