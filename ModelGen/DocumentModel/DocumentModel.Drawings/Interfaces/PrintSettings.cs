namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface PrintSettings
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public HeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public PageMargins? PageMargins { get ; set; }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public PageSetup? PageSetup { get ; set; }
  
}
