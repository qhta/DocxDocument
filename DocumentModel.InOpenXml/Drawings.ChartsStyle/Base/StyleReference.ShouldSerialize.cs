namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class StyleReference
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeModifiers() => Modifiers is not null;
}
