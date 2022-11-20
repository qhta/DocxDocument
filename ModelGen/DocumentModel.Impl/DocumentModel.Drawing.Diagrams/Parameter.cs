namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public class Parameter: IParameter
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  public ParameterIdValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
