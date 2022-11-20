namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBuiltInUnit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDisplayUnitsLabel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ICustomDisplayUnit))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
public interface IDisplayUnits // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
