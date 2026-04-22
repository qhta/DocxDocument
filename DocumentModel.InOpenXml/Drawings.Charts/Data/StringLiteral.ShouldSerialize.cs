namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class StringLiteral
{
  public bool ShouldSerializePointCount() => PointCount is not null;
  public bool ShouldSerializeStringPoints() => StringPoints is not null;
  public bool ShouldSerializeStrDataExtension() => StrDataExtension is not null;
}
