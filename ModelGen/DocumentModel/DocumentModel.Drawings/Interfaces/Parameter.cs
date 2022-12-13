namespace DocumentModel.Drawings;

/// <summary>
/// Parameter.
/// </summary>
public interface Parameter
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  public DocumentModel.Drawings.ParameterIdKind? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
}
