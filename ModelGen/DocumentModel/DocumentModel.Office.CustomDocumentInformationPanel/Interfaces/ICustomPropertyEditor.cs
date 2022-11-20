namespace DocumentModel.Office.CustomDocumentInformationPanel;

/// <summary>
/// Defines the CustomPropertyEditor Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.CustomDocumentInformationPanel.IPropertyEditorNamespace))]
[ChildElementInfo(typeof(DocumentModel.Office.CustomDocumentInformationPanel.IXsnFileLocation))]
public interface ICustomPropertyEditor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// PropertyEditorNamespace.
  /// </summary>
  public IPropertyEditorNamespace? PropertyEditorNamespace { get ; set; }
  
  /// <summary>
  /// XsnFileLocation.
  /// </summary>
  public IXsnFileLocation? XsnFileLocation { get ; set; }
  
}
