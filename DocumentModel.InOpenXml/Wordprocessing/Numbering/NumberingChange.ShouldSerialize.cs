namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingChange
{
  public bool ShouldSerializeOriginal() => !String.IsNullOrEmpty(Original);
}
