namespace DocumentModel.Interop;

/// <summary>
/// A collection of TableOfFigures objects that represent the tables of figures in a document.
/// </summary>
public partial interface TablesOfFigures : InteropObject, InteropCollection<TableOfFigures>
{
  /// <summary>
  /// The format.
  /// </summary>
  public WdTofFormat Format { get; set; }
}
