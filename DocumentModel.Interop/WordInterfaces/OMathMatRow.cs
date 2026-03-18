namespace DocumentModel.Interop;

/// <summary>
/// Represents a matrix row. The OMathMatRow is a member of the OMathMatRows collection.
/// </summary>
public partial interface OMathMatRow : InteropObject
{
  /// <summary>
  /// The args.
  /// </summary>
  public OMathArgs Args { get; }

  /// <summary>
  /// The row index.
  /// </summary>
  public int RowIndex { get; }
}
