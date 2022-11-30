namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the IgnoredErrors Class.
/// </summary>
public interface IIgnoredErrors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.IIgnoredError>? IgnoredErrors { get ; set; }
  
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList { get ; set; }
  
}
