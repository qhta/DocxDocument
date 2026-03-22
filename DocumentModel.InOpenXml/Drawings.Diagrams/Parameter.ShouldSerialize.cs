namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Parameter
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeVal() => !String.IsNullOrEmpty(Val);
}
