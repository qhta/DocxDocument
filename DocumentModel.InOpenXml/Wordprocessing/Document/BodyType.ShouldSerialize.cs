namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class BodyType
{
  public bool ShouldSerializeSections() => Sections is not null;
}
