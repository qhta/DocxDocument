namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculated Item.
/// </summary>
public interface CalculatedItem // : DocumentModel.BaseTypes.ModelElement
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
  public PivotArea? PivotArea { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
