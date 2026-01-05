namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ValAxExtension Class.
/// </summary>
public interface ValAxExtension:
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NumberingFormat3? NumberingFormat { get; set; }
}