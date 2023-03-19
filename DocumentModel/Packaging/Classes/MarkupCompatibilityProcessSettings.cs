namespace DocumentModel.Packaging;

/// <summary>
///   Represents markup compatibility processing settings.
/// </summary>
public class MarkupCompatibilityProcessSettings: ModelElement
{
  /// <summary>
  ///   Gets the markup compatibility process mode.
  /// </summary>
  public MarkupCompatibilityProcessMode? ProcessMode { get; set; }

  /// <summary>
  ///   Gets the target file format versions.
  /// </summary>
  public FileFormatVersions? TargetFileFormatVersions { get; set; }
}