namespace DocumentModel.Wordprocessing;

public partial class Bibliography
{
  public bool ShouldSerializeSources() => Sources is not null;
  public bool ShouldSerializeMasterList() => MasterList is not null;
  public bool ShouldSerializeCurrentList() => CurrentList is not null;
  public bool ShouldSerializeBibliographyStyle() => BibliographyStyle is not null;
  public bool ShouldSerializeSortOrder() => SortOrder is not null;
  public bool ShouldSerializeShowAllSources() => ShowAllSources == true;
}
