namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a date axis, providing additional numbering format options.
/// </summary>
public interface DateAxExtension : Extension
{
  /// <summary>
  ///   Numbering format configuration for the date axis extension.
  /// </summary>
  public NumberingFormat3? NumberingFormat { get; set; }
}