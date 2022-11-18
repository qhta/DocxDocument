namespace DocumentModel.Spreadsheet;

/// <summary>
/// Outline Properties.
/// </summary>
public interface IOutlineProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Apply Styles in Outline
  /// </summary>
  public bool? ApplyStyles { get ; set; }
  
  /// <summary>
  /// Summary Below
  /// </summary>
  public bool? SummaryBelow { get ; set; }
  
  /// <summary>
  /// Summary Right
  /// </summary>
  public bool? SummaryRight { get ; set; }
  
  /// <summary>
  /// Show Outline Symbols
  /// </summary>
  public bool? ShowOutlineSymbols { get ; set; }
  
}
