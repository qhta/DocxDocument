namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class AbstractBody<T> 
{
  public bool ShouldSerializeSections() => Sections is not null && ShouldSerialize(Sections);
}
