namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DateAxExtension Class.
/// </summary>
public class DateAxExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NumberingFormat3? NumberingFormat { get; set; }
}