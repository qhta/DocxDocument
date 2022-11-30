namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the IgnoredErrors Class.
/// </summary>
public interface IIgnoredErrors // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IIgnoredError>? IgnoredErrors { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
