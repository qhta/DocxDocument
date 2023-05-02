namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Associated Status Text.
/// </summary>
public class StatusText: ModelElement
{
  /// <summary>
  ///   Status Text Type
  /// </summary>
  public InfoTextKind? Type { get; set; }

  /// <summary>
  ///   Status Text Value
  /// </summary>
  public string? Val { get; set; }
}