namespace DocumentModel.Spreadsheet;

/// <summary>
/// Outline Properties.
/// </summary>
public interface IOutlineProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Apply Styles in Outline
  /// </summary>
  public Boolean? ApplyStyles { get ; set; }
  
  /// <summary>
  /// Summary Below
  /// </summary>
  public Boolean? SummaryBelow { get ; set; }
  
  /// <summary>
  /// Summary Right
  /// </summary>
  public Boolean? SummaryRight { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public Boolean? ShowOutlineSymbols { get ; set; }
  
}
