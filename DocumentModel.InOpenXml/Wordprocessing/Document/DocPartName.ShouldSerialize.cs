namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocPartName
{
  public bool ShouldSerializeVal() => !String.IsNullOrEmpty(Val);
  public bool ShouldSerializeDecorated() => Decorated is not null;
}
