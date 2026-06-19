namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class MathProperties
{
  public bool ShouldSerializeMathFont() => !String.IsNullOrEmpty(Typeface);
  public bool ShouldSerializeBreakBinary() => BreakBinary is not null;
  public bool ShouldSerializeBreakBinarySubtraction() => BreakBinarySubtraction is not null;
  public bool ShouldSerializeSmallFraction() => SmallFraction is not null;
  public bool ShouldSerializeDisplayDefaults() => DisplayDefaults is not null;
  public bool ShouldSerializeLeftMargin() => LeftMargin is not null;
  public bool ShouldSerializeRightMargin() => RightMargin is not null;
  public bool ShouldSerializeDefaultJustification() => DefaultJustification is not null;
  public bool ShouldSerializePreSpacing() => PreSpacing is not null;
  public bool ShouldSerializePostSpacing() => PostSpacing is not null;
  public bool ShouldSerializeInterSpacing() => InterSpacing is not null;
  public bool ShouldSerializeIntraSpacing() => IntraSpacing is not null;
  public bool ShouldSerializeWrapIndent() => WrapIndent is not null;
  public bool ShouldSerializeWrapRight() => WrapRight is not null;
  public bool ShouldSerializeIntegralLimitLocation() => IntegralLimitLocation is not null;
  public bool ShouldSerializeNaryLimitLocation() => NaryLimitLocation is not null;
}
