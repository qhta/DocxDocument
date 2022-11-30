namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public interface ITasks // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2021.DocumentTasks.ITask>? Tasks { get ; set; }
  
  public DocumentModel.Office2021.DocumentTasks.IExtensionList? ExtensionList { get ; set; }
  
}
