namespace DocumentModel.Drawing;

/// <summary>
/// Parameter.
/// </summary>
public interface IParameter // : DocumentModel.ITypedOpenXmlLeafElement
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
