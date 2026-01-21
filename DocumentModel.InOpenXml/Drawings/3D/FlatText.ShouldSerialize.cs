namespace DocumentModel.Drawings;

public partial class FlatText
{
  public bool ShouldSerializeZ() => Z is not null;
}
