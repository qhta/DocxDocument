namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the IgnoredErrors Class.
/// </summary>
public interface IgnoredErrors // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<IgnoredError>? IgnoredErrors { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
