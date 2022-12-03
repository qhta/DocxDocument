namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableUISettings Class.
/// </summary>
public interface PivotTableUISettings // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// sourceDataName, this property is only available in Office 2013 and later.
  /// </summary>
  public String? SourceDataName { get ; set; }
  
  /// <summary>
  /// relNeededHidden, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? RelNeededHidden { get ; set; }
  
  public Collection<FieldListActiveTabTopLevelEntity>? FieldListActiveTabTopLevelEntities { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
