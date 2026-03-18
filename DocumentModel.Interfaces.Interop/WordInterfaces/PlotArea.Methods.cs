namespace DocumentModel.Interop;

public partial interface PlotArea
{
  /// <summary>
  /// Selects and returns an object based on the current context or criteria.
  /// </summary>
  /// <returns>An object representing the selected item. The specific type and value depend on the implementation and context.</returns>
  public object Select();
}
