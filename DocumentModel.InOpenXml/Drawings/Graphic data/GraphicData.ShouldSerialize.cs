namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class GraphicData
{
  public bool ShouldSerializeUriString() => UriString is not null;
}
