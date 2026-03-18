namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class TextBodyProperties
{
  public bool ShouldSerializeRotation() => Rotation is not null;
  public bool ShouldSerializeUseParagraphSpacing() => UseParagraphSpacing is not null;
  public bool ShouldSerializeVerticalOverflow() => VerticalOverflow is not null;
  public bool ShouldSerializeHorizontalOverflow() => HorizontalOverflow is not null;
  public bool ShouldSerializeVertical() => Vertical is not null;
  public bool ShouldSerializeWrap() => Wrap is not null;
  public bool ShouldSerializeLeftInset() => LeftInset is not null;
  public bool ShouldSerializeTopInset() => TopInset is not null;
  public bool ShouldSerializeRightInset() => RightInset is not null;
  public bool ShouldSerializeBottomInset() => BottomInset is not null;
  public bool ShouldSerializeColumnCount() => ColumnCount is not null;
  public bool ShouldSerializeColumnSpacing() => ColumnSpacing is not null;
  public bool ShouldSerializeRightToLeftColumns() => RightToLeftColumns is not null;
  public bool ShouldSerializeFromWordArt() => FromWordArt is not null;
  public bool ShouldSerializeAnchor() => Anchor is not null;
  public bool ShouldSerializeAnchorCenter() => AnchorCenter is not null;
  public bool ShouldSerializeForceAntiAlias() => ForceAntiAlias is not null;
  public bool ShouldSerializeUpRight() => UpRight is not null;
  public bool ShouldSerializeCompatibleLineSpacing() => CompatibleLineSpacing is not null;
  public bool ShouldSerializePresetTextWrap() => PresetTextWrap is not null;
  public bool ShouldSerializeNoAutoFit() => NoAutoFit is not null;
  public bool ShouldSerializeNormalAutoFit() => NormalAutoFit is not null;
  public bool ShouldSerializeShapeAutoFit() => ShapeAutoFit is not null;
  public bool ShouldSerializeScene3DType() => Scene3DType is not null;
  public bool ShouldSerializeShape3DType() => Shape3DType is not null;
  public bool ShouldSerializeFlatText() => FlatText is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
