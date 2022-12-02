namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public interface ISketchOptions // : DocumentModel.ITypedOpenXmlCompositeElement
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
