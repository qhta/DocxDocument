namespace DocumentModel.Spreadsheet;

/// <summary>
/// Parameter Properties.
/// </summary>
public class Parameter: IParameter
{
  /// <summary>
  /// Parameter Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// SQL Data Type
  /// </summary>
  public int? SqlType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Parameter Type
  /// </summary>
  public ParameterValues? ParameterType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Refresh on Change
  /// </summary>
  public bool? RefreshOnChange
  {
    get;
    set;
  }
  
  /// <summary>
  /// Parameter Prompt String
  /// </summary>
  public string? Prompt
  {
    get;
    set;
  }
  
  /// <summary>
  /// Boolean
  /// </summary>
  public bool? Boolean
  {
    get;
    set;
  }
  
  /// <summary>
  /// Double
  /// </summary>
  public double? Double
  {
    get;
    set;
  }
  
  /// <summary>
  /// Integer
  /// </summary>
  public int? Integer
  {
    get;
    set;
  }
  
  /// <summary>
  /// String
  /// </summary>
  public string? String
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cell Reference
  /// </summary>
  public string? Cell
  {
    get;
    set;
  }
  
}
