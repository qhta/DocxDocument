namespace DocumentModel;

/// <summary>
/// Defines the Tasks Class.
/// </summary>
public interface ITasks // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.ITask>? Tasks { get ; set; }
  
  public DocumentModel.IExtensionList? ExtensionList { get ; set; }
  
}
