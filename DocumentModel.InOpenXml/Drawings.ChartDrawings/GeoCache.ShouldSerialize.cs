namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class GeoCache
{
  public bool ShouldSerializeProvider() => !String.IsNullOrEmpty(Provider);
  public bool ShouldSerializeXsdBase64Binary() => !String.IsNullOrEmpty(XsdBase64Binary);
  public bool ShouldSerializeClear() => Clear is not null;
}
