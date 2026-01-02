namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StrDataExtension Class.
/// </summary>
public class StrDataExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public bool? AutoGeneneratedCategories { get; set; }
}