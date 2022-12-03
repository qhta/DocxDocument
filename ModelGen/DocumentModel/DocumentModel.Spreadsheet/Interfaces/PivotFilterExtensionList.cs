namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotFilterExtensionList Class.
/// </summary>
public interface PivotFilterExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<PivotFilterExtension>? PivotFilterExtensions { get ; set; }
  
}
