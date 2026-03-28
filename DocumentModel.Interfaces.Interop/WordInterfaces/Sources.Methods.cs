namespace DocumentModel.Interop;

public partial interface Sources
{
  /// <summary>
  /// Adds a new source to the collection.
  /// </summary>
  /// <param name="Data">The data for the new source.</param>
  public void Add(string Data);
}
