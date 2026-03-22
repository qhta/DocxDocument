namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class FillTextEffect
{
  public bool ShouldSerializeNoFillEmpty() => NoFillEmpty is not null;
  public bool ShouldSerializeSolidColorFillProperties() => SolidColorFillProperties is not null;
  public bool ShouldSerializeGradientFillProperties() => GradientFillProperties is not null;
}
