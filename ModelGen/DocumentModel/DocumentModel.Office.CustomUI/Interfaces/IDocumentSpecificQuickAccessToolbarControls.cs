namespace DocumentModel.Office.CustomUI;

/// <summary>
/// Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IUnsizedButton))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IQuickAccessToolbarControlClone))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomUI.IVerticalSeparator))]
public interface IDocumentSpecificQuickAccessToolbarControls // : DocumentFormat.OpenXml.Office.CustomUI.QatItemsType
{
}
