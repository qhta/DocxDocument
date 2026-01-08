namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a value axis, providing additional numbering format options.
/// </summary>
public interface ValAxExtension : Extension
{
  /// <summary>
  ///   Numbering format configuration for the value axis extension.
  /// </summary>
  public NumberingFormat3? NumberingFormat { get; set; }
}