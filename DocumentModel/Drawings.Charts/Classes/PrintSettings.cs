namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public class PrintSettings: ModelElement
{
  /// <summary>
  ///   Header and Footer.
  /// </summary>
  public IHeaderFooter? IHeaderFooter { get; set; }

  /// <summary>
  ///   IPage Margins.
  /// </summary>
  public PageMargins? PageMargins { get; set; }

  /// <summary>
  ///   IPage Setup.
  /// </summary>
  public IPageSetup? IPageSetup { get; set; }

  /// <summary>
  ///   Legacy Drawing for Headers and Footers.
  /// </summary>
  public RelationshipIdType? LegacyDrawingHeaderFooter { get; set; }
}
