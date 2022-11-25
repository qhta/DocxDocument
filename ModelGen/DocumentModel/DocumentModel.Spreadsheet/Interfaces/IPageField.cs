namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Field.
/// </summary>
public interface IPageField // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field
  /// </summary>
  public System.Int32? Field { get ; set; }
  
  /// <summary>
  /// Item Index
  /// </summary>
  public System.UInt32? Item { get ; set; }
  
  /// <summary>
  /// OLAP Hierarchy Index
  /// </summary>
  public System.Int32? Hierarchy { get ; set; }
  
  /// <summary>
  /// Hierarchy Unique Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Hierarchy Display Name
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
