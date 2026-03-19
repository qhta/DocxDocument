namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorDefinitionTitle))]
/// <summary>
/// Represents the Color Definition Title.
/// </summary>
public class ColorDefinitionTitle: ModelElement<DXDD.ColorDefinitionTitle>
{
  /// <summary>
  ///   Language
  /// </summary>
  public string? Language { get; set; }
  /// <summary>
  ///   Description Value
  /// </summary>
  public string? Val { get; set; }
}
