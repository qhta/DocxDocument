namespace DocumentModel.Spreadsheet;

/// <summary>
/// Print Options.
/// </summary>
public interface IPrintOptions // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Centered
  /// </summary>
  public Boolean? HorizontalCentered { get ; set; }
  
  /// <summary>
  /// Vertical Centered
  /// </summary>
  public Boolean? VerticalCentered { get ; set; }
  
  /// <summary>
  /// Print Headings
  /// </summary>
  public Boolean? Headings { get ; set; }
  
  /// <summary>
  /// Print Grid Lines
  /// </summary>
  public Boolean? GridLines { get ; set; }
  
  /// <summary>
  /// Grid Lines Set
  /// </summary>
  public Boolean? GridLinesSet { get ; set; }
  
}
