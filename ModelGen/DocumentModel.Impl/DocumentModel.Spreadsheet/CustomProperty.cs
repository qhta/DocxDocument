namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Property.
/// </summary>
public class CustomProperty: ICustomProperty
{
  /// <summary>
  /// Custom Property Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
