namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ValAxExtension Class.
/// </summary>
public record ValAxExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public NumberingFormat3? NumberingFormat { get; set; }
}