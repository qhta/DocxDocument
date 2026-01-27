namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Callout
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeGap() => Gap is not null;
  public bool ShouldSerializeAngle() => Angle is not null;
  public bool ShouldSerializeDropAuto() => DropAuto is not null;
  public bool ShouldSerializeDrop() => Drop is not null;
  public bool ShouldSerializeDistance() => Distance is not null;
  public bool ShouldSerializeLengthSpec() => LengthSpec is not null;
  public bool ShouldSerializeLength() => Length is not null;
  public bool ShouldSerializeAccentBar() => AccentBar is not null;
  public bool ShouldSerializeTextBorder() => TextBorder is not null;
  public bool ShouldSerializeMinusX() => MinusX is not null;
  public bool ShouldSerializeMinusY() => MinusY is not null;
}
