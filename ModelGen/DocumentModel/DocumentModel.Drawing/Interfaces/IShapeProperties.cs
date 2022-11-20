namespace DocumentModel.Drawing;

/// <summary>
/// Visual Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ICustomGeometry))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetGeometry))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IScene3DType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShape3DType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShapePropertiesExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITransform2D))]
public interface IShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  public DocumentModel.Drawing.ITransform2D? Transform2D { get ; set; }
  
}
