namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Delimiter
{
  public bool ShouldSerializeDelimiterProperties() => DelimiterProperties is not null;
}
