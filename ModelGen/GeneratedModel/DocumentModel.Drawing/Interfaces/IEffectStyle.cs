namespace DocumentModel.Drawing;

/// <summary>
/// Effect Style.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectDag))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEffectList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IScene3DType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShape3DType))]
public interface IEffectStyle // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
