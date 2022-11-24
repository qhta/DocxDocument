namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public interface IParameter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  public ParameterIdValues? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
}
