namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the EndCxnConnection Class.
/// </summary>
public class EndCxnConnection: IEndCxnConnection
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
