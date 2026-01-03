namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ChartData Class.
/// </summary>
public interface ChartData: IModelElement
{
  /// <summary>
  ///   ExternalData.
  /// </summary>
  public ExternalData? ExternalData { get; set; }
  public Data? Data { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}