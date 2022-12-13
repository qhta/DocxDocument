namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface PrintSettings
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Drawings16.Charts.HeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PageSetup? PageSetup { get ; set; }
  
}
