namespace DocumentModel.Office2016.Drawing;

/// <summary>
/// Defines the ConnectableReferences Class.
/// </summary>
public class ConnectableReferences: IConnectableReferences
{
  /// <summary>
  /// st, this property is only available in Office 2016 and later.
  /// </summary>
  public string? St
  {
    get;
    set;
  }
  
  /// <summary>
  /// end, this property is only available in Office 2016 and later.
  /// </summary>
  public string? End
  {
    get;
    set;
  }
  
}
