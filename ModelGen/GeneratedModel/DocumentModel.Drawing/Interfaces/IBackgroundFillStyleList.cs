namespace DocumentModel.Drawing;

/// <summary>
/// Background Fill Style List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlipFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGradientFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INoFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPatternFill))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ISolidFill))]
public interface IBackgroundFillStyleList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
