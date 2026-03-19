namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Text Body.
/// </summary>
[OpenXmlType(typeof(DXDD.TextBody))]
/// <summary>
/// Represents the Text Body.
/// </summary>
public class TextBody: ModelElement<DXDD.TextBody>
{
  /// <summary>
  ///   Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }
  /// <summary>
  ///   Text List Styles.
  /// </summary>
  public ListStyle? ListStyle { get; set; }
  /// <summary>
  /// Paragraph.
  /// </summary>
  public Paragraph? Paragraph { get; set; }
}

