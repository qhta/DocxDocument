namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Color Transform Definitions.
/// </summary>
public class ColorsDefinition: ModelElement
{
  /// <summary>
  ///   Unique ID
  /// </summary>
  public string? UniqueId { get; set; }

  /// <summary>
  ///   Minimum Version
  /// </summary>
  public string? MinVersion { get; set; }

  public Collection<ColorDefinitionTitle>? ColorDefinitionTitles { get; set; }

  public Collection<ColorTransformDescription>? ColorTransformDescriptions { get; set; }

  public ColorTransformCategories? ColorTransformCategories { get; set; }

  public Collection<ColorTransformStyleLabel>? ColorTransformStyleLabels { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}