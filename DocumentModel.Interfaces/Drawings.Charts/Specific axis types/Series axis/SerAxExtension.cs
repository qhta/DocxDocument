namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a series axis, providing additional numbering format options.
/// </summary>
public interface SerAxExtension : Extension
{
  /// <summary>
  ///   Numbering format configuration for the series axis extension.
  /// </summary>
  public NumberingFormat3? NumberingFormat { get; set; }
}