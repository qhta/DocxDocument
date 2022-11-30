namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public interface IExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2021.OfficeExtLst.IExtension>? Extensions { get ; set; }
  
}
