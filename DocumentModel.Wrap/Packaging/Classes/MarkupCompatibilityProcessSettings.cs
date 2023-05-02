namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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