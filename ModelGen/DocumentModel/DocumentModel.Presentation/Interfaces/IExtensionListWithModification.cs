namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionListWithModification Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtension))]
public interface IExtensionListWithModification // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Modify
  /// </summary>
  public bool? Modify { get ; set; }
  
}
