namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Style Definition.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDefinition))]
/// <summary>
/// Represents the Style Definition.
/// </summary>
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
  /// <summary>
  /// Style Definition Titles.
  /// </summary>
  public StyleDefinitionTitles? StyleDefinitionTitles { get; set; }
  /// <summary>
  /// Style Label Descriptions.
  /// </summary>
  public StyleLabelDescriptions? StyleLabelDescriptions { get; set; }
  /// <summary>
  /// Style Display Categories.
  /// </summary>
  public StyleDisplayCategories? StyleDisplayCategories { get; set; }
  /// <summary>
  /// Scene3 D.
  /// </summary>
  public Scene3D? Scene3D { get; set; }
  /// <summary>
  /// Style Label.
  /// </summary>
  public StyleLabel? StyleLabel { get; set; }
  /// <summary>
  /// Extension List.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}


