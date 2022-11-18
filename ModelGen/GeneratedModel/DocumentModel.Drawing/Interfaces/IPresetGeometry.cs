namespace DocumentModel.Drawing;

/// <summary>
/// Preset geometry.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAdjustValueList))]
public interface IPresetGeometry // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  public ShapeType? Preset { get ; set; }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public IAdjustValueList? AdjustValueList { get ; set; }
  
}
