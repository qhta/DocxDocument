namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorDefinitionTitle))]
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