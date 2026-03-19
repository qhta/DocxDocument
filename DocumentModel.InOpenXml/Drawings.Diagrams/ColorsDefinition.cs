namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Color Transform Definitions.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorsDefinition))]
/// <summary>
/// Represents the Colors Definition.
/// </summary>
public class ColorsDefinition: ModelElement<DXDD.ColorsDefinition>
{
  /// <summary>
  ///   Unique ID
  /// </summary>
  public string? UniqueId { get; set; }
  /// <summary>
  ///   Minimum Version
  /// </summary>
  public string? MinVersion { get; set; }
  /// <summary>
  /// Color Definition Titles.
  /// </summary>
  public ColorDefinitionTitles? ColorDefinitionTitles { get; set; }
  /// <summary>
  /// Color Transform Descriptions.
  /// </summary>
  public ColorTransformDescriptions? ColorTransformDescriptions { get; set; }
  /// <summary>
  /// Color Transform Categories.
  /// </summary>
  public ColorTransformCategories? ColorTransformCategories { get; set; }
  /// <summary>
  /// Color Transform Style Labels.
  /// </summary>
  public ColorTransformStyleLabels? ColorTransformStyleLabels { get; set; }
  /// <summary>
  /// Extension List.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}

