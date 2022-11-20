namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the ServerFormat Class.
/// </summary>
public class ServerFormat: IServerFormat
{
  /// <summary>
  /// Culture
  /// </summary>
  public string? Culture
  {
    get;
    set;
  }
  
  /// <summary>
  /// Format
  /// </summary>
  public string? Format
  {
    get;
    set;
  }
  
}
