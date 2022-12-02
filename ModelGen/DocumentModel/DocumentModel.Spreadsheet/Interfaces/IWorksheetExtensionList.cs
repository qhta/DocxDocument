namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetExtensionList Class.
/// </summary>
public interface IWorksheetExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IWorksheetExtension>? WorksheetExtensions { get ; set; }
  
}
