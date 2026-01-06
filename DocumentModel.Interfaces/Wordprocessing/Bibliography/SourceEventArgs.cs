namespace DocumentModel.Wordprocessing;

/// <summary>
///   Provides data for source-related events.
/// </summary>
public class SourceEventArgs : EventArgs
{
  /// <summary>
  ///   Gets the source that triggered the event.
  /// </summary>
  public Source? Source { get; init; }

  /// <summary>
  ///   Gets the tag of the source.
  /// </summary>
  public string? SourceTag { get; init; }
}