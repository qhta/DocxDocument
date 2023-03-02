namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StrDataExtension Class.
/// </summary>
public record StrDataExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public Boolean? AutoGeneneratedCategories { get; set; }
}