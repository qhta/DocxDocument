namespace DocumentModel.Drawing;

/// <summary>
/// Parameter.
/// </summary>
public interface IParameter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  public DocumentModel.Drawing.ParameterIdKind? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.String? Val { get ; set; }
  
}
