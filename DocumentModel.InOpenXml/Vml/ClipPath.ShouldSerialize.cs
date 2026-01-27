namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class ClipPath
{
  public bool ShouldSerializeValue() => Value is not null;
}
