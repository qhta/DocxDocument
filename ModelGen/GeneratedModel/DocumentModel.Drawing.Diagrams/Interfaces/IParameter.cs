namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public interface IParameter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  public ParameterId? Type { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public string? Val { get ; set; }
  
}
