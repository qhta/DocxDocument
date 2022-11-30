namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Field Item.
/// </summary>
public interface IDataField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// fld
  /// </summary>
  public System.UInt32? Field { get ; set; }
  
  /// <summary>
  /// subtotal
  /// </summary>
  public DocumentModel.Spreadsheet.DataConsolidateFunctionKind? Subtotal { get ; set; }
  
  /// <summary>
  /// showDataAs
  /// </summary>
  public DocumentModel.Spreadsheet.ShowDataAsKind? ShowDataAs { get ; set; }
  
  /// <summary>
  /// baseField
  /// </summary>
  public System.Int32? BaseField { get ; set; }
  
  /// <summary>
  /// baseItem
  /// </summary>
  public System.UInt32? BaseItem { get ; set; }
  
  /// <summary>
  /// numFmtId
  /// </summary>
  public System.UInt32? NumberFormatId { get ; set; }
  
  /// <summary>
  /// DataFieldExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IDataFieldExtensionList? DataFieldExtensionList { get ; set; }
  
}
