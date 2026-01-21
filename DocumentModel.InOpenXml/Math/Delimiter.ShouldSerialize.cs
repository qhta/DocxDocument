namespace DocumentModel.Math;

public partial class Delimiter
{
  public bool ShouldSerializeDelimiterProperties() => DelimiterProperties is not null;
}
