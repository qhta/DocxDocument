namespace DocumentModel.Wordprocessing;

/// <summary>
///   Associated Status Text.
/// </summary>
public record StatusText
{
  /// <summary>
  ///   Status Text Type
  /// </summary>
  public InfoTextKind? Type { get; set; }

  /// <summary>
  ///   Status Text Value
  /// </summary>
  public String? Val { get; set; }
}