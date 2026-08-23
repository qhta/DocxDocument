namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an absolute position tab character in a text run in WordprocessingML documents.
/// An absolute position tab advances the position on the current line of text to a specified alignment and base, regardless of custom tab stops or default tab stop width. If the alignment location cannot be found on the current line, the tab advances to that location on the next available line.
/// </summary>
[OpenXmlType(typeof(DXW.PositionalTab))]
[DataContract]
[XmlRoot("PositionalTab", Namespace = "DocumentModel.Wordprocessing")]
public partial class PositionalTab: ModelElement<DXW.PositionalTab>, IRunContent
{
  /// <summary>
  /// Alignment for the positional tab stop, specifying how the tab aligns relative to the target position.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.PositionalTab.Alignment))]
  public AbsolutePositionTabAlignment? Alignment
  {
    get => _Alignment ??= GetProperty<AbsolutePositionTabAlignment?>(GetUpdatableElement()?.Alignment);
    set => UpdateField(ref _Alignment, value, nameof(Alignment));
  }

  private AbsolutePositionTabAlignment? _Alignment;

  /// <summary>
  /// Base for the positional tab stop, specifying the reference point for tab alignment (e.g., margin, indent).
  /// </summary>
  [OpenXmlProperty(nameof(DXW.PositionalTab.RelativeTo))]
  public AbsolutePositionTabPositioningBase? RelativeTo
  {
    get => _RelativeTo ??= GetProperty<AbsolutePositionTabPositioningBase?>(GetUpdatableElement()?.RelativeTo);
    set => UpdateField(ref _RelativeTo, value, nameof(RelativeTo));
  }

  private AbsolutePositionTabPositioningBase? _RelativeTo;

  /// <summary>
  /// Leader character for the tab, specifying the character used to fill the space advanced by the tab.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.PositionalTab.Leader))]
  public AbsolutePositionTabLeaderChar? Leader
  {
    get => _Leader ??= GetProperty<AbsolutePositionTabLeaderChar?>(GetUpdatableElement()?.Leader);
    set => UpdateField(ref _Leader, value, nameof(Leader));
  }

  private AbsolutePositionTabLeaderChar? _Leader;
}