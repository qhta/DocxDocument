namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Shape Drawing Properties.
/// </summary>
public interface NonVisualShapeDrawingProperties
{
  /// <summary>
  /// Text Box
  /// </summary>
  public Boolean? TextBox { get ; set; }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public DocumentModel.Drawings.ShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
