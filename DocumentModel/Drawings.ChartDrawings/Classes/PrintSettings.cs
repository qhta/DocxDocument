namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public partial class PrintSettings
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.HeaderFooter? HeaderFooter { get; set; }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.PageMargins? PageMargins { get; set; }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.PageSetup? PageSetup { get; set; }
  
}
