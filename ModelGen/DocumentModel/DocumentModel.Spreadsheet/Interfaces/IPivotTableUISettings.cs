namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableUISettings Class.
/// </summary>
public interface IPivotTableUISettings // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// sourceDataName, this property is only available in Office 2013 and later.
  /// </summary>
  public String? SourceDataName { get ; set; }
  
  /// <summary>
  /// relNeededHidden, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? RelNeededHidden { get ; set; }
  
  public Collection<IFieldListActiveTabTopLevelEntity>? FieldListActiveTabTopLevelEntities { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
