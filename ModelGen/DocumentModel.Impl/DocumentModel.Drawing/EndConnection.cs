namespace DocumentModel.Drawing;

/// <summary>
/// Connection End.
/// </summary>
public class EndConnection: IEndConnection
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
