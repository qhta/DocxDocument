namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface IExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IExtension>? Extensions { get ; set; }
  
}
