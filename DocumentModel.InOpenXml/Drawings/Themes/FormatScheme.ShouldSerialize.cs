namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class FormatScheme
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeFillStyleList() => FillStyleList is not null;
  public bool ShouldSerializeLineStyleList() => LineStyleList is not null;
  public bool ShouldSerializeEffectStyleList() => EffectStyleList is not null;
  public bool ShouldSerializeBackgroundFillStyleList() => BackgroundFillStyleList is not null;
}
