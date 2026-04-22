namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class PictureAttributionSourceURL
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
}
