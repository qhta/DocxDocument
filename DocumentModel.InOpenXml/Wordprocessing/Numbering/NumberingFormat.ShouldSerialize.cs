namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingFormat
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeCustom() => !String.IsNullOrEmpty(Custom);
}
