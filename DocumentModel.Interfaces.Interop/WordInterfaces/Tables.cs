namespace DocumentModel.Interop;

/// <summary>
/// A collection of Table objects that represent the tables in a selection, range, or document.
/// </summary>
public partial interface Tables : InteropObject, InteropCollection<Table>
{
  /// <summary>
  /// The nesting level.
  /// </summary>
  public int NestingLevel { get; }
}
