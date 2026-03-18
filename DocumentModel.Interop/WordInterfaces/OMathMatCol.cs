namespace DocumentModel.Interop;

/// <summary>
/// Represents a matrix column. The OMathMatCol object is a member of the OMathMatCols collection.
/// </summary>
public partial interface OMathMatCol : InteropObject
{
  /// <summary>
  /// The args.
  /// </summary>
  public OMathArgs Args { get; }

  /// <summary>
  /// The col index.
  /// </summary>
  public int ColIndex { get; }

  /// <summary>
  /// The align.
  /// </summary>
  public WdOMathHorizAlignType Align { get; set; }
}
