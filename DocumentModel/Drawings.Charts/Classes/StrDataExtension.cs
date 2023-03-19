namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StrDataExtension Class.
/// </summary>
public class StrDataExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public Boolean? AutoGeneneratedCategories { get; set; }
}