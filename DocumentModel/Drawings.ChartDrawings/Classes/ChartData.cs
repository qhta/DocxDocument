namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ChartData Class.
/// </summary>
public record ChartData
{
  /// <summary>
  ///   ExternalData.
  /// </summary>
  public ExternalData? ExternalData { get; set; }

  public Data? Data { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}