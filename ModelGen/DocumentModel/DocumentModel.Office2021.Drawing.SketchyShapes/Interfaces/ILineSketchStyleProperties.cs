namespace DocumentModel.Office2021.Drawing.SketchyShapes;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public interface ILineSketchStyleProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public System.UInt32? Sd { get ; set; }
  
}
