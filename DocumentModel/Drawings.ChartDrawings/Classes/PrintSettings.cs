namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public class PrintSettings: ModelElement
{
  /// <summary>
  ///   HeaderFooter.
  /// </summary>
  public HeaderFooter? HeaderFooter { get; set; }

  /// <summary>
  ///   PageMargins.
  /// </summary>
  public PageMargins? PageMargins { get; set; }

  /// <summary>
  ///   PageSetup.
  /// </summary>
  public PageSetup? PageSetup { get; set; }
}