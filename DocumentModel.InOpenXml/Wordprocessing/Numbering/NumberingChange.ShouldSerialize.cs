namespace DocumentModel.Wordprocessing;

public partial class NumberingChange
{
  public bool ShouldSerializeOriginal() => Original is not null;
}
