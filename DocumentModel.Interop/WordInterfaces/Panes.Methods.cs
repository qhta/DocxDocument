namespace DocumentModel.Interop.Word;

public partial interface Panes
{
  /// <summary>
  /// Adds a new pane to the collection, optionally splitting the current pane vertically or horizontally.
  /// </summary>
  /// <remarks>The orientation of the split is determined by the value of <paramref name="SplitVertical"/>. The
  /// method creates a new pane adjacent to the current one based on the specified split direction.</remarks>
  /// <param name="SplitVertical">A value indicating whether to split the pane vertically. Pass <see langword="true"/> to split vertically; <see
  /// langword="false"/> to split horizontally.</param>
  /// <returns>A <see cref="Pane"/> object representing the newly added pane.</returns>
  public Pane Add(bool SplitVertical);
}
