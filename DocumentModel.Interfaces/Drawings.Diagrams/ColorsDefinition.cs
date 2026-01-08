namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Color Transform Definitions.
/// </summary>
public interface ColorsDefinition
{
  /// <summary>
  ///   Unique ID
  /// </summary>
  public string? UniqueId { get; set; }
  /// <summary>
  ///   Minimum Version
  /// </summary>
  public string? MinVersion { get; set; }
  public ColorDefinitionTitles ColorDefinitionTitles { get; set; }
  public ColorTransformDescriptions ColorTransformDescriptions { get; set; }
  public ColorTransformCategories? ColorTransformCategories { get; set; }
  public ColorTransformStyleLabels ColorTransformStyleLabels { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}