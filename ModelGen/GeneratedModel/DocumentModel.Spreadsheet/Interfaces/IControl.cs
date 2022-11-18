namespace DocumentModel.Spreadsheet;

/// <summary>
/// Embedded Control.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IControlProperties))]
public interface IControl // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Id
  /// </summary>
  public uint? ShapeId { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Control Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// ControlProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.IControlProperties? ControlProperties { get ; set; }
  
}
