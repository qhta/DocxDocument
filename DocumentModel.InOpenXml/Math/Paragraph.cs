namespace DocumentModel.Math;
/// <summary>
///   This element specifies a math paragraph, or display math zone, 
///   that contains one or more oMath elements that are in display mode. 
///   The oMath containers of a display math zone are not themselves considered inline math zones.
/// </summary>
[OpenXmlType(typeof(DXM.Paragraph))]
[DataContract]
[XmlRoot("Paragraph", Namespace = "DocumentModel.Math")]
public partial class Paragraph : ModelElement<DXM.Paragraph>, ICommonMathContent
{
  /// <summary>
  ///   Office Math Paragraph Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Paragraph.ParagraphProperties))]
  public ParagraphProperties? ParagraphProperties
  {
    get => _ParagraphProperties;
    set => UpdateField(ref _ParagraphProperties, value, nameof(ParagraphProperties));
  }
  private ParagraphProperties? _ParagraphProperties;
}