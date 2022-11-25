namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotTableUISettings Class.
/// </summary>
public interface IPivotTableUISettings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// sourceDataName, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? SourceDataName { get ; set; }
  
  /// <summary>
  /// relNeededHidden, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? RelNeededHidden { get ; set; }
  
}
