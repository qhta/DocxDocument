namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Axis Class.
/// </summary>
public interface IAxis // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? Hidden { get ; set; }
  
}
