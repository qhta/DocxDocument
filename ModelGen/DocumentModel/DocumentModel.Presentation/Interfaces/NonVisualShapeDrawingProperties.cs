namespace DocumentModel.Presentation;

/// <summary>
/// Non-Visual Drawing Properties for a Shape.
/// </summary>
public interface NonVisualShapeDrawingProperties // : DocumentModel.BaseTypes.ModelElement
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
