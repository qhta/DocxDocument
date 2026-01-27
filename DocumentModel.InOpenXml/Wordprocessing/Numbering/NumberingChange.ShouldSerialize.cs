namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingChange
{
  public bool ShouldSerializeOriginal() => Original is not null;
}
