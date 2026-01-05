namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DateAxExtension Class.
/// </summary>
public interface DateAxExtension:
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public NumberingFormat3? NumberingFormat { get; set; }
}