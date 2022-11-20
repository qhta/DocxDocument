namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Field.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IPageField // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field
  /// </summary>
  public int? Field { get ; set; }
  
  /// <summary>
  /// Item Index
  /// </summary>
  public uint? Item { get ; set; }
  
  /// <summary>
  /// OLAP Hierarchy Index
  /// </summary>
  public int? Hierarchy { get ; set; }
  
  /// <summary>
  /// Hierarchy Unique Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Hierarchy Display Name
  /// </summary>
  public string? Caption { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
