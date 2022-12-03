namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public interface SketchOptions // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// InSketchMode.
  /// </summary>
  public Boolean? InSketchMode { get ; set; }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  public Boolean? ShowSketchButton { get ; set; }
  
}
