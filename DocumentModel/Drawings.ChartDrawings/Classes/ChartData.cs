namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ChartData Class.
/// </summary>
public class ChartData: ModelElement
{
  /// <summary>
  ///   ExternalData.
  /// </summary>
  public ExternalData? ExternalData { get; set; }

  public Data? Data { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}