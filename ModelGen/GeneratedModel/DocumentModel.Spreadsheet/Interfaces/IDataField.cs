namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Field Item.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataFieldExtensionList))]
public interface IDataField // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// fld
  /// </summary>
  public uint? Field { get ; set; }
  
  /// <summary>
  /// subtotal
  /// </summary>
  public DataConsolidateFunction? Subtotal { get ; set; }
  
  /// <summary>
  /// showDataAs
  /// </summary>
  public ShowDataAs? ShowDataAs { get ; set; }
  
  /// <summary>
  /// baseField
  /// </summary>
  public int? BaseField { get ; set; }
  
  /// <summary>
  /// baseItem
  /// </summary>
  public uint? BaseItem { get ; set; }
  
  /// <summary>
  /// numFmtId
  /// </summary>
  public uint? NumberFormatId { get ; set; }
  
  /// <summary>
  /// DataFieldExtensionList.
  /// </summary>
  public IDataFieldExtensionList? DataFieldExtensionList { get ; set; }
  
}
