namespace DocumentModel.Wordprocessing;

public partial class BodyType
{
  public bool ShouldSerializeSections() => Sections is not null;
}
