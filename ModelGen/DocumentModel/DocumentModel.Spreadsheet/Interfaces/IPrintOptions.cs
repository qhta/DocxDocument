namespace DocumentModel.Spreadsheet;

/// <summary>
/// Print Options.
/// </summary>
public interface IPrintOptions // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Centered
  /// </summary>
  public System.Boolean? HorizontalCentered { get ; set; }
  
  /// <summary>
  /// Vertical Centered
  /// </summary>
  public System.Boolean? VerticalCentered { get ; set; }
  
  /// <summary>
  /// Print Headings
  /// </summary>
  public System.Boolean? Headings { get ; set; }
  
  /// <summary>
  /// Print Grid Lines
  /// </summary>
  public System.Boolean? GridLines { get ; set; }
  
  /// <summary>
  /// Grid Lines Set
  /// </summary>
  public System.Boolean? GridLinesSet { get ; set; }
  
}
