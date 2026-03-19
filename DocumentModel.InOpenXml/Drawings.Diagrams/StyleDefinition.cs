namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Style Definition.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDefinition))]
public class StyleDefinition: ModelElement<DXDD.StyleDefinition>
{
  /// <summary>
  ///   Unique Style ID
  /// </summary>
  public string? UniqueId { get; set; }
  /// <summary>
  ///   Minimum Version
  /// </summary>
  public string? MinVersion { get; set; }
  public StyleDefinitionTitles? StyleDefinitionTitles { get; set; }
  public StyleLabelDescriptions? StyleLabelDescriptions { get; set; }
  public StyleDisplayCategories? StyleDisplayCategories { get; set; }
  public Scene3D? Scene3D { get; set; }
  public StyleLabel? StyleLabel { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}

[OpenXmlType(typeof(DXDD.StyleLabelDescription))]
public class StyleLabelDescriptions : ModelElementCollection<StyleLabelDescription>
{
}