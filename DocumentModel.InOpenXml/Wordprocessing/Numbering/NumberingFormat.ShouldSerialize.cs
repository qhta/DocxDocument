namespace DocumentModel.Wordprocessing;

public partial class NumberingFormat
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeCustom() => Custom is not null;
}
