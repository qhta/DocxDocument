namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the CatAxExtension Class.
/// </summary>
public interface CatAxExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NumberingFormat3? NumberingFormat { get; set; }
}