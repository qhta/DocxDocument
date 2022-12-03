namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WorksheetExtensionList Class.
/// </summary>
public interface WorksheetExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<WorksheetExtension>? WorksheetExtensions { get ; set; }
  
}
