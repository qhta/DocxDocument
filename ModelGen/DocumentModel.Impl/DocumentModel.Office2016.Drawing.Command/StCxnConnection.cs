namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the StCxnConnection Class.
/// </summary>
public class StCxnConnection: IStCxnConnection
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
