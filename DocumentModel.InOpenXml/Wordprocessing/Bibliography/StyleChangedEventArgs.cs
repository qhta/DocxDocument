namespace DocumentModel.Wordprocessing;
/// <summary>
///   Provides data for style changed events.
/// </summary>
public partial class StyleChangedEventArgs : EventArgs
{
  /// <summary>
  ///   Gets the previous style name.
  /// </summary>
  public string? OldStyle { get; init; }
  /// <summary>
  ///   Gets the new style name.
  /// </summary>
  public string? NewStyle { get; init; }
}