namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SeriesLayoutProperties Class.
/// </summary>
public class SeriesLayoutProperties: ModelElement
{
  /// <summary>
  ///   ParentLabelLayout.
  /// </summary>
  public ParentLabelLayout? ParentLabelLayout { get; set; }

  /// <summary>
  ///   RegionLabelLayout.
  /// </summary>
  public RegionLabelLayoutEnum? RegionLabelLayout { get; set; }

  /// <summary>
  ///   SeriesElementVisibilities.
  /// </summary>
  public SeriesElementVisibilities? SeriesElementVisibilities { get; set; }

  public bool? Aggregation { get; set; }

  public Binning? Binning { get; set; }

  public Geography? Geography { get; set; }

  public Statistics? Statistics { get; set; }

  public Subtotals? Subtotals { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}