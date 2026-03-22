namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class NumberDataType
{
  public bool ShouldSerializeFormatCode() => !String.IsNullOrEmpty(FormatCode);
  public bool ShouldSerializePointCount() => PointCount is not null;
}
