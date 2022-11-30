namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFieldExtensionList Class.
/// </summary>
public interface IDataFieldExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IDataFieldExtension>? DataFieldExtensions { get ; set; }
  
}
