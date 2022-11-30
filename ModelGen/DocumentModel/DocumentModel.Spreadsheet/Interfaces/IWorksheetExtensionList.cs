namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetExtensionList Class.
/// </summary>
public interface IWorksheetExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IWorksheetExtension>? WorksheetExtensions { get ; set; }
  
}
