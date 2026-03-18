namespace DocumentModel.Interop;

public partial interface SeriesLines
{
  /// <summary>
  /// Selects and returns an object based on the current context or criteria.
  /// </summary>
  /// <returns>An object representing the selected item. The specific type and meaning of the returned object depend on the
  /// implementation.</returns>
  public object Select();
}
