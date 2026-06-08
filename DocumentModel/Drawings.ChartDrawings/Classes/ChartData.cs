namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the IChartData Class.
/// </summary>
public class IChartData: ModelElement
{
  /// <summary>
  ///   ExternalData.
  /// </summary>
  public ExternalData? ExternalData { get; set; }

  public Data? Data { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
