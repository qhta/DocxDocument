namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public interface ISketchOptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// InSketchMode.
  /// </summary>
  public InSketchMode? InSketchMode { get ; set; }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  public IShowSketchButton? ShowSketchButton { get ; set; }
  
}
