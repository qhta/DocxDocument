namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtensionListModify Class.
/// </summary>
public interface IExtensionListModify // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Modify
  /// </summary>
  public System.Boolean? Modify { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IExtension>? Extensions { get ; set; }
  
}
