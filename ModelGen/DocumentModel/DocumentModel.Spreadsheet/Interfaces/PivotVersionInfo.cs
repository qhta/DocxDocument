namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotVersionInfo Class.
/// </summary>
public interface PivotVersionInfo // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<String>? RequiredFeatureXsdstrings { get ; set; }
  
  public Collection<String>? LastUpdateFeatureXsdstrings { get ; set; }
  
}
