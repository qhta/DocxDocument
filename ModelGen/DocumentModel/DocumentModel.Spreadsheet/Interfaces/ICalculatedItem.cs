namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculated Item.
/// </summary>
public interface ICalculatedItem // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Index
  /// </summary>
  public UInt32? Field { get ; set; }
  
  /// <summary>
  /// Calculated Item Formula
  /// </summary>
  public String? Formula { get ; set; }
  
  /// <summary>
  /// Calculated Item Location.
  /// </summary>
  public IPivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
