namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the border settings for a paragraph in a WordprocessingML document.
/// This class provides properties for configuring borders on all sides of a paragraph, as well as between identical paragraphs and between facing pages, enabling advanced formatting and visual separation of paragraph content.
/// </summary>
[OpenXmlType(typeof(DXW.ParagraphBorders))]
[XmlRoot("ParagraphBorders", Namespace = "DocumentModel.Wordprocessing")]
public partial class ParagraphBorders : ModelElement<DXW.ParagraphBorders>
{
 /// <summary>
 /// Border above identical paragraphs, specifying the top border of the paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphBorders.TopBorder))]
 public Border? TopBorder { get => _TopBorder; set => UpdateField(ref _TopBorder, value, nameof(TopBorder)); }
 private Border? _TopBorder;

 /// <summary>
 /// Left border of the paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphBorders.LeftBorder))]
 public Border? LeftBorder { get => _LeftBorder; set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder)); }
 private Border? _LeftBorder;

 /// <summary>
 /// Border between identical paragraphs, specifying the bottom border of the paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphBorders.BottomBorder))]
 public Border? BottomBorder { get => _BottomBorder; set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder)); }
 private Border? _BottomBorder;

 /// <summary>
 /// Right border of the paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphBorders.RightBorder))]
 public Border? RightBorder { get => _RightBorder; set => UpdateField(ref _RightBorder, value, nameof(RightBorder)); }
 private Border? _RightBorder;

 /// <summary>
 /// Border between identical paragraphs, used to visually separate consecutive paragraphs with the same formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphBorders.BetweenBorder))]
 public Border? BetweenBorder { get => _BetweenBorder; set => UpdateField(ref _BetweenBorder, value, nameof(BetweenBorder)); }
 private Border? _BetweenBorder;

 /// <summary>
 /// Border between facing pages, specifying a vertical bar border for the paragraph.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.ParagraphBorders.BarBorder))]
 public Border? BarBorder { get => _BarBorder; set => UpdateField(ref _BarBorder, value, nameof(BarBorder)); }
 private Border? _BarBorder;
}