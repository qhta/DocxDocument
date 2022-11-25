namespace DocumentModel.Spreadsheet;

/// <summary>
/// Outline Properties.
/// </summary>
public interface IOutlineProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Apply Styles in Outline
  /// </summary>
  public System.Boolean? ApplyStyles { get ; set; }
  
  /// <summary>
  /// Summary Below
  /// </summary>
  public System.Boolean? SummaryBelow { get ; set; }
  
  /// <summary>
  /// Summary Right
  /// </summary>
  public System.Boolean? SummaryRight { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public System.Boolean? ShowOutlineSymbols { get ; set; }
  
}
