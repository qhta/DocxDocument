namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Format.
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
