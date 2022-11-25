namespace DocumentModel.Spreadsheet;

/// <summary>
/// Embedded Control.
/// </summary>
public interface IControl // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Id
  /// </summary>
  public System.UInt32? ShapeId { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Control Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// ControlProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Spreadsheet.IControlProperties? ControlProperties { get ; set; }
  
}
