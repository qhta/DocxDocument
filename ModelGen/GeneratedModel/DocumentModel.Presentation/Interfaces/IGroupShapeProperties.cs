namespace DocumentModel.Presentation;

/// <summary>
/// Group Shape Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITransformGroup))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IScene3DType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
public interface IGroupShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public ITransformGroup? TransformGroup { get ; set; }
  
}
