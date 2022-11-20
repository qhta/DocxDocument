namespace DocumentModel.Drawing;

/// <summary>
/// Connection Start.
/// </summary>
public class StartConnection: IStartConnection
{
  /// <summary>
  /// Identifier
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Index
  /// </summary>
  public uint? Index
  {
    get;
    set;
  }
  
}
