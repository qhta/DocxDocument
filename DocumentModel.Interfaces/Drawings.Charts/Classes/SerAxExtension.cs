namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the SerAxExtension Class.
/// </summary>
public interface SerAxExtension:
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NumberingFormat3? NumberingFormat { get; set; }
}