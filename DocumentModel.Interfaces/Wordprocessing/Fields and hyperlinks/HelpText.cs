namespace DocumentModel.Wordprocessing;

/// <summary>
///   Associated Help Text.
/// </summary>
public class HelpText: ModelElement
{
  /// <summary>
  ///   Help Text Type
  /// </summary>
  public InfoTextKind? Type { get; set; }
  /// <summary>
  ///   Help Text Value
  /// </summary>
  public string? Val { get; set; }
}