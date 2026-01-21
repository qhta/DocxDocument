namespace DocumentModel.Vml;

public partial class Entry
{
  public bool ShouldSerializeNew() => New is not null;
  public bool ShouldSerializeOld() => Old is not null;
}
