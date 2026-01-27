namespace DocumentModel.Wordprocessing;

public partial class BaseParagraphProperties<T> 
{
  public bool ShouldSerializeKeepNext() => KeepNext is not null;
  public bool ShouldSerializeKeepLines() => KeepLines is not null;
  public bool ShouldSerializePageBreakBefore() => PageBreakBefore is not null;
  public bool ShouldSerializeFrameProperties() => FrameProperties is not null;
  public bool ShouldSerializeWidowControl() => WidowControl is not null;
  public bool ShouldSerializeNumberingProperties() => NumberingProperties is not null;
  public bool ShouldSerializeSuppressLineNumbers() => SuppressLineNumbers is not null;
  public bool ShouldSerializeParagraphBorders() => ParagraphBorders is not null;
  public bool ShouldSerializeShading() => Shading is not null;
  public bool ShouldSerializeTabs() => Tabs is not null;
  public bool ShouldSerializeSuppressAutoHyphens() => SuppressAutoHyphens is not null;
  public bool ShouldSerializeKinsoku() => Kinsoku is not null;
  public bool ShouldSerializeWordWrap() => WordWrap is not null;
  public bool ShouldSerializeOverflowPunctuation() => OverflowPunctuation is not null;
  public bool ShouldSerializeTopLinePunctuation() => TopLinePunctuation is not null;
  public bool ShouldSerializeAutoSpaceDE() => AutoSpaceDE is not null;
  public bool ShouldSerializeAutoSpaceDN() => AutoSpaceDN is not null;
  public bool ShouldSerializeBiDi() => BiDi is not null;
  public bool ShouldSerializeAdjustRightIndent() => AdjustRightIndent is not null;
  public bool ShouldSerializeSnapToGrid() => SnapToGrid is not null;
  public bool ShouldSerializeSpacingBetweenLines() => SpacingBetweenLines is not null;
  public bool ShouldSerializeIndentation() => Indentation is not null;
  public bool ShouldSerializeContextualSpacing() => ContextualSpacing is not null;
  public bool ShouldSerializeMirrorIndents() => MirrorIndents is not null;
  public bool ShouldSerializeSuppressOverlap() => SuppressOverlap is not null;
  public bool ShouldSerializeJustification() => Justification is not null;
  public bool ShouldSerializeTextDirection() => TextDirection is not null;
  public bool ShouldSerializeTextAlignment() => TextAlignment is not null;
  public bool ShouldSerializeTextBoxTightWrap() => TextBoxTightWrap is not null;
  public bool ShouldSerializeOutlineLevel() => OutlineLevel is not null;
}
