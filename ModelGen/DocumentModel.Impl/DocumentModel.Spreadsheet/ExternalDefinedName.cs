namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defined Name.
/// </summary>
public class ExternalDefinedName: IExternalDefinedName
{
  /// <summary>
  /// Defined Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Refers To
  /// </summary>
  public string? RefersTo
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId
  {
    get;
    set;
  }
  
}
