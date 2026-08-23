namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the border settings for a paragraph in a WordprocessingML document.
/// This class provides properties for configuring borders on all sides of a paragraph, as well as between identical paragraphs and between facing pages, enabling advanced formatting and visual separation of paragraph content.
/// </summary>
[OpenXmlType(typeof(DXW.ParagraphBorders))]
[DataContract]
[XmlRoot("ParagraphBorders", Namespace = "DocumentModel.Wordprocessing")]
public partial class ParagraphBorders: ModelElement<DXW.ParagraphBorders>
{
  /// <summary>
  /// Border above identical paragraphs, specifying the top border of the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphBorders.TopBorder))]
  public Border? TopBorder
  {
    get => _TopBorder ??= GetProperty<Border?>(GetUpdatableElement(nameof(TopBorder))?.TopBorder);
    set => UpdateField(ref _TopBorder, value, nameof(TopBorder));
  }

  private Border? _TopBorder;

  /// <summary>
  /// Left border of the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphBorders.LeftBorder))]
  public Border? LeftBorder
  {
    get => _LeftBorder ??= GetProperty<Border?>(GetUpdatableElement(nameof(LeftBorder))?.LeftBorder);
    set => UpdateField(ref _LeftBorder, value, nameof(LeftBorder));
  }

  private Border? _LeftBorder;

  /// <summary>
  /// Border between identical paragraphs, specifying the bottom border of the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphBorders.BottomBorder))]
  public Border? BottomBorder
  {
    get => _BottomBorder ??= GetProperty<Border?>(GetUpdatableElement(nameof(BottomBorder))?.BottomBorder);
    set => UpdateField(ref _BottomBorder, value, nameof(BottomBorder));
  }

  private Border? _BottomBorder;

  /// <summary>
  /// Right border of the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphBorders.RightBorder))]
  public Border? RightBorder
  {
    get => _RightBorder ??= GetProperty<Border?>(GetUpdatableElement(nameof(RightBorder))?.RightBorder);
    set => UpdateField(ref _RightBorder, value, nameof(RightBorder));
  }

  private Border? _RightBorder;

  /// <summary>
  /// Border between identical paragraphs, used to visually separate consecutive paragraphs with the same formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphBorders.BetweenBorder))]
  public Border? BetweenBorder
  {
    get => _BetweenBorder ??= GetProperty<Border?>(GetUpdatableElement(nameof(BetweenBorder))?.BetweenBorder);
    set => UpdateField(ref _BetweenBorder, value, nameof(BetweenBorder));
  }

  private Border? _BetweenBorder;

  /// <summary>
  /// Border between facing pages, specifying a vertical bar border for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.ParagraphBorders.BarBorder))]
  public Border? BarBorder
  {
    get => _BarBorder ??= GetProperty<Border?>(GetUpdatableElement(nameof(BarBorder))?.BarBorder);
    set => UpdateField(ref _BarBorder, value, nameof(BarBorder));
  }

  private Border? _BarBorder;


  /// <summary>
  /// Gets or sets the underlying Open XML element that can be updated by this model element.
  /// It can be an OpenXmlElement or any other object that represents the data source for this model.
  /// If null, a new OpenXmlType element is created.
  /// </summary>
  public override DXW.ParagraphBorders? GetUpdatableObject(object? context)
  {
    return base.GetUpdatableObject(context) as DXW.ParagraphBorders;
  }
}