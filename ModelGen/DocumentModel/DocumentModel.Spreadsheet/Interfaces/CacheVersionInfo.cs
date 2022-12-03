namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheVersionInfo Class.
/// </summary>
public interface CacheVersionInfo // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<String>? RequiredFeatureXsdstrings { get ; set; }
  
  public Collection<String>? LastRefreshFeatureXsdstrings { get ; set; }
  
}
