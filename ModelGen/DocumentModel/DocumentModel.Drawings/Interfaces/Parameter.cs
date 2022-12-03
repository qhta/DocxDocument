namespace DocumentModel.Drawings;

/// <summary>
/// Parameter.
/// </summary>
public interface Parameter // : System.Boolean
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  public ParameterIdKind? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
}
