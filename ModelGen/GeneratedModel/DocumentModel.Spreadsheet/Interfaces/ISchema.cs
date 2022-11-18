namespace DocumentModel.Spreadsheet;

/// <summary>
/// XML Schema.
/// </summary>
public interface ISchema // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Schema ID
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Schema Reference
  /// </summary>
  public string? SchemaReference { get ; set; }
  
  /// <summary>
  /// Schema Root Namespace
  /// </summary>
  public string? Namespace { get ; set; }
  
}
