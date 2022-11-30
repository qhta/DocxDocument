namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculated Item.
/// </summary>
public interface ICalculatedItem // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Index
  /// </summary>
  public System.UInt32? Field { get ; set; }
  
  /// <summary>
  /// Calculated Item Formula
  /// </summary>
  public System.String? Formula { get ; set; }
  
  /// <summary>
  /// Calculated Item Location.
  /// </summary>
  public DocumentModel.Spreadsheet.IPivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
