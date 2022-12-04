namespace DocumentModel.Packaging;

/// <summary>
/// Represents markup compatibility processing settings.
/// </summary>
public class MarkupCompatibilityProcessSettings
{
  /// <summary>
  /// Gets the markup compatibility process mode.
  /// </summary>
  public MarkupCompatibilityProcessMode? ProcessMode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the target file format versions.
  /// </summary>
  public DocumentModel.FileFormatVersions? TargetFileFormatVersions
  {
    get;
    set;
  }
  
}
