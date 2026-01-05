namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the CatAxExtension Class.
/// </summary>
public interface CatAxExtension:
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NumberingFormat3? NumberingFormat { get; set; }
}