namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Properties.
/// </summary>
public interface CustomProperties // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<CustomProperty>? CustomProperties { get ; set; }
  
}
