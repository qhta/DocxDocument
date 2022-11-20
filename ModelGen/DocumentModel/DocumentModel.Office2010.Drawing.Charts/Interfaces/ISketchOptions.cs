namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IInSketchMode))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IShowSketchButton))]
public interface ISketchOptions // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// InSketchMode.
  /// </summary>
  public IInSketchMode? InSketchMode { get ; set; }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  public IShowSketchButton? ShowSketchButton { get ; set; }
  
}
