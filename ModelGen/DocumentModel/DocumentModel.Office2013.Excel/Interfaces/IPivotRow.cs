namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotRow Class.
/// </summary>
public interface IPivotRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// r, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Reference { get ; set; }
  
  /// <summary>
  /// count, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
}
