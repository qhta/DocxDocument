namespace DocumentModel.Vml;

public partial class ClipPath
{
  public bool ShouldSerializeValue() => Value is not null;
}
