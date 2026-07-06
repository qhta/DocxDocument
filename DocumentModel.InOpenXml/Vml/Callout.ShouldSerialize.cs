namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Callout
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeType() => !String.IsNullOrEmpty(Type);
  public bool ShouldSerializeGap() => !String.IsNullOrEmpty(Gap);
  public bool ShouldSerializeAngle() => Angle is not null;
  public bool ShouldSerializeDropAuto() => DropAuto is not null;
  public bool ShouldSerializeDrop() => !String.IsNullOrEmpty(Drop);
  public bool ShouldSerializeDistance() => !String.IsNullOrEmpty(Distance);
  public bool ShouldSerializeLengthSpec() => LengthSpecified is not null;
  public bool ShouldSerializeLength() => !String.IsNullOrEmpty(Length);
  public bool ShouldSerializeAccentBar() => AccentBar is not null;
  public bool ShouldSerializeTextBorder() => TextBorder is not null;
  public bool ShouldSerializeMinusX() => MinusX is not null;
  public bool ShouldSerializeMinusY() => MinusY is not null;
}
