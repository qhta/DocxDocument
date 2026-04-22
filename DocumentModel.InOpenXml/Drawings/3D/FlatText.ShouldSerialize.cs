namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class FlatText
{
  public bool ShouldSerializeZ() => Z is not null;
}
