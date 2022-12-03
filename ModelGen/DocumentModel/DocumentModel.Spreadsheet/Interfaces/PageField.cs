namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Field.
/// </summary>
public interface PageField // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Field
  /// </summary>
  public Int32? Field { get ; set; }
  
  /// <summary>
  /// Item Index
  /// </summary>
  public UInt32? Item { get ; set; }
  
  /// <summary>
  /// OLAP Hierarchy Index
  /// </summary>
  public Int32? Hierarchy { get ; set; }
  
  /// <summary>
  /// Hierarchy Unique Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Hierarchy Display Name
  /// </summary>
  public String? Caption { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
