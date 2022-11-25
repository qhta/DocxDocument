namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public interface ISketchOptions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// InSketchMode.
  /// </summary>
  public System.Boolean? InSketchMode { get ; set; }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  public System.Boolean? ShowSketchButton { get ; set; }
  
}
