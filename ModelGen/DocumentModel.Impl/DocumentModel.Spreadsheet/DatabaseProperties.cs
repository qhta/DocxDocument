namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DatabaseProperties Class.
/// </summary>
public class DatabaseProperties: IDatabaseProperties
{
  /// <summary>
  /// Connection String
  /// </summary>
  public string? Connection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Command Text
  /// </summary>
  public string? Command
  {
    get;
    set;
  }
  
  /// <summary>
  /// Command Text
  /// </summary>
  public string? ServerCommand
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLE DB Command Type
  /// </summary>
  public uint? CommandType
  {
    get;
    set;
  }
  
}
