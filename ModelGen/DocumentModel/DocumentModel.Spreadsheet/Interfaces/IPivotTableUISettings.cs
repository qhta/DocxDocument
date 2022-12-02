namespace DocumentModel.Spreadsheet;

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
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IFieldListActiveTabTopLevelEntity>? FieldListActiveTabTopLevelEntities { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
