namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a category axis, providing additional numbering format options.
/// </summary>
public interface CatAxExtension : Extension
{
  /// <summary>
  ///   Numbering format configuration for the category axis extension.
  /// </summary>
  public NumberingFormat3? NumberingFormat { get; set; }
}