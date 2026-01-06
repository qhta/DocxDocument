namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StrDataExtension Class.
/// </summary>
public interface StrDataExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public bool? AutoGeneneratedCategories { get; set; }
}