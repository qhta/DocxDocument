namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class SchemeColor
{
  public bool ShouldSerializeVal() => Index is not null;
}
