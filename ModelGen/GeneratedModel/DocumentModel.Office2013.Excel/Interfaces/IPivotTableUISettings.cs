namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotTableUISettings Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IFieldListActiveTabTopLevelEntity))]
public interface IPivotTableUISettings // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// sourceDataName, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SourceDataName { get ; set; }
  
  /// <summary>
  /// relNeededHidden, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? RelNeededHidden { get ; set; }
  
}
