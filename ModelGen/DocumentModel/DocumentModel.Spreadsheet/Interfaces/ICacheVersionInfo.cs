namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheVersionInfo Class.
/// </summary>
public interface ICacheVersionInfo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<String>? RequiredFeatureXsdstrings { get ; set; }
  
  public Collection<String>? LastRefreshFeatureXsdstrings { get ; set; }
  
}
