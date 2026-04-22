namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class LineJoinMiterProperties
{
  public bool ShouldSerializeLimit() => Limit is not null;
}
