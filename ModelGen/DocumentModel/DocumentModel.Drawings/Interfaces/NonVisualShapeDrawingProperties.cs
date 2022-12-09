namespace DocumentModel.Drawings;

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
  public ShapeLocks? ShapeLocks { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}
