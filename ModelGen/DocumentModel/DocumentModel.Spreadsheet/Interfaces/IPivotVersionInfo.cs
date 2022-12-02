namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotVersionInfo Class.
/// </summary>
public interface IPivotVersionInfo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<String>? RequiredFeatureXsdstrings { get ; set; }
  
  public Collection<String>? LastUpdateFeatureXsdstrings { get ; set; }
  
}
