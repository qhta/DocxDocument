namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ValAxExtension Class.
/// </summary>
public interface ValAxExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NumberingFormat3? NumberingFormat { get; set; }
}