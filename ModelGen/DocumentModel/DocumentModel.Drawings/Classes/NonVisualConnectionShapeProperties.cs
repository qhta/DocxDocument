namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
public class NonVisualConnectionShapeProperties
{
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  public ConnectionShapeLocks? ConnectionShapeLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  public Boolean? StartConnection
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
