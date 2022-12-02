namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheVersionInfo Class.
/// </summary>
public interface ICacheVersionInfo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<System.String>? RequiredFeatureXsdstrings { get ; set; }
  
  public System.Collections.ObjectModel.Collection<System.String>? LastRefreshFeatureXsdstrings { get ; set; }
  
}
