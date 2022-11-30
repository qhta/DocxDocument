namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionListWithModification Class.
/// </summary>
public interface IExtensionListWithModification // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Modify
  /// </summary>
  public System.Boolean? Modify { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IExtension>? Extensions { get ; set; }
  
}
