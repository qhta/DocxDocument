namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableDefinitionExtensionList Class.
/// </summary>
public interface PivotTableDefinitionExtensionList // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<PivotTableDefinitionExtension>? PivotTableDefinitionExtensions { get ; set; }
  
}
