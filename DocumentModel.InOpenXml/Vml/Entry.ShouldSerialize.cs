namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class Entry
{
  public bool ShouldSerializeNew() => New is not null;
  public bool ShouldSerializeOld() => Old is not null;
}
