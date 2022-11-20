namespace DocumentModel.Spreadsheet;

/// <summary>
/// Print Options.
/// </summary>
public interface IPrintOptions // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Centered
  /// </summary>
  public bool? HorizontalCentered { get ; set; }
  
  /// <summary>
  /// Vertical Centered
  /// </summary>
  public bool? VerticalCentered { get ; set; }
  
  /// <summary>
  /// Print Headings
  /// </summary>
  public bool? Headings { get ; set; }
  
  /// <summary>
  /// Print Grid Lines
  /// </summary>
  public bool? GridLines { get ; set; }
  
  /// <summary>
  /// Grid Lines Set
  /// </summary>
  public bool? GridLinesSet { get ; set; }
  
}
