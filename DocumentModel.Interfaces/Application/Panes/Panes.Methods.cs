namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.panes?view=word-pia"/>
public partial interface IPanes: IModelObject
{
  /// <summary>
  /// Adds a new pane to the collection, optionally splitting the current pane vertically or horizontally.
  /// </summary>
  /// <remarks>The orientation of the split is determined by the value of <paramref name="SplitVertical"/>. The
  /// method creates a new pane adjacent to the current one based on the specified split direction.</remarks>
  /// <param name="SplitVertical">A value indicating whether to split the pane vertically. Pass <see langword="true"/> to split vertically; <see
  /// langword="false"/> to split horizontally.</param>
  /// <returns>A <see cref="IPane"/> object representing the newly added pane.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.panes.add?view=word-pia"/>
  public IPane Add(bool SplitVertical);
}
