namespace DocumentModel.Drawings;

public partial class GraphicData
{
  public bool ShouldSerializeUriString() => UriString is not null;
}
