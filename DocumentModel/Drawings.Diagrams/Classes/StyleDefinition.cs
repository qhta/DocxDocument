namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Style Definition.
/// </summary>
public class StyleDefinition: ModelElement
{
  /// <summary>
  ///   Unique Style ID
  /// </summary>
  public string? UniqueId { get; set; }

  /// <summary>
  ///   Minimum Version
  /// </summary>
  public string? MinVersion { get; set; }

  public Collection<StyleDefinitionTitle>? StyleDefinitionTitles { get; set; }

  public Collection<StyleLabelDescription>? StyleLabelDescriptions { get; set; }

  public StyleDisplayCategories? StyleDisplayCategories { get; set; }

  public Scene3D? Scene3D { get; set; }

  public StyleLabel? StyleLabel { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}