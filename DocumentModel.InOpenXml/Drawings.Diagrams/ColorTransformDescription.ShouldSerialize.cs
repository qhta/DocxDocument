namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class ColorTransformDescription
{
  public bool ShouldSerializeLanguage() => !String.IsNullOrEmpty(Language);
  public bool ShouldSerializeVal() => !String.IsNullOrEmpty(Val);
}
