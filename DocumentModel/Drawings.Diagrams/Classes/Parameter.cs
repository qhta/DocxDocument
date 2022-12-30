namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public partial class Parameter
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ParameterIdKind? Type { get; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get; set; }
  
}
