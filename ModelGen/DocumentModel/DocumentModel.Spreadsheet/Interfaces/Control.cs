namespace DocumentModel.Spreadsheet;

/// <summary>
/// Embedded Control.
/// </summary>
public interface Control // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Shape Id
  /// </summary>
  public UInt32? ShapeId { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Control Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// ControlProperties, this property is only available in Office 2010 and later..
  /// </summary>
  public ControlProperties? ControlProperties { get ; set; }
  
}
