namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public class PrintSettings: ModelElement
{
  /// <summary>
  ///   IHeaderFooter.
  /// </summary>
  public IHeaderFooter? IHeaderFooter { get; set; }

  /// <summary>
  ///   PageMargins.
  /// </summary>
  public PageMargins? PageMargins { get; set; }

  /// <summary>
  ///   IPageSetup.
  /// </summary>
  public IPageSetup? IPageSetup { get; set; }
}
