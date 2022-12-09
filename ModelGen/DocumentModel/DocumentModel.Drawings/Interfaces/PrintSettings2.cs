namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public interface PrintSettings2
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public HeaderFooter1? HeaderFooter { get ; set; }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  public PageMargins2? PageMargins { get ; set; }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  public PageSetup1? PageSetup { get ; set; }
  
}
