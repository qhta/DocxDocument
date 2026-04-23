namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseParagraphProperties<T> 
{
  public bool ShouldSerializeKeepNext() => KeepNext is not null;
  public bool ShouldSerializeKeepLines() => KeepLines is not null;
  public bool ShouldSerializePageBreakBefore() => PageBreakBefore is not null;
  public bool ShouldSerializeFrameProperties() => FrameProperties is not null && ShouldSerialize(FrameProperties);
  public bool ShouldSerializeWidowControl() => WidowControl is not null;
  public bool ShouldSerializeSuppressLineNumbers() => SuppressLineNumbers is not null;
  public bool ShouldSerializeBorders() => Borders is not null && ShouldSerialize(Borders);
  public bool ShouldSerializeShading() => Shading is not null && ShouldSerialize(Shading);
  public bool ShouldSerializeTabs() => Tabs is not null && ShouldSerialize(Tabs);
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
  public bool ShouldSerializeSpacingBefore() => SpacingBefore is not null && ShouldSerialize(SpacingBefore);
  public bool ShouldSerializeSpacingAfter() => SpacingAfter is not null && ShouldSerialize(SpacingAfter);
  public bool ShouldSerializeSpacingInterline() => SpacingInterline is not null && ShouldSerialize(SpacingInterline);
  public bool ShouldSerializeSpacingByContext() => SpacingByContext is not null;
  public bool ShouldSerializeIndentation() => Indentation is not null && ShouldSerialize(Indentation);
  public bool ShouldSerializeMirrorIndents() => MirrorIndents is not null;
  public bool ShouldSerializeSuppressOverlap() => SuppressOverlap is not null;
  public bool ShouldSerializeJustification() => Justification is not null && ShouldSerialize(Justification);
  public bool ShouldSerializeTextDirection() => TextDirection is not null && ShouldSerialize(TextDirection);
  public bool ShouldSerializeVerticalTextAlignment() => VerticalTextAlignment is not null && ShouldSerialize(VerticalTextAlignment);
  public bool ShouldSerializeTextBoxTightWrap() => TextBoxTightWrap is not null && ShouldSerialize(TextBoxTightWrap);
  public bool ShouldSerializeOutlineLevel() => OutlineLevel is not null && ShouldSerialize(OutlineLevel);
  public bool ShouldSerializeNumberingProperties() => NumberingProperties is not null && ShouldSerialize(NumberingProperties);
}
