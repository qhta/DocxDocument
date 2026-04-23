namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Bibliography
{
  public bool ShouldSerializeSources() => Sources is not null && ShouldSerialize(Sources);
  public bool ShouldSerializeMasterList() => MasterList is not null && ShouldSerialize(MasterList);
  public bool ShouldSerializeCurrentList() => CurrentList is not null && ShouldSerialize(CurrentList);
  public bool ShouldSerializeBibliographyStyle() => !String.IsNullOrEmpty(BibliographyStyle);
  public bool ShouldSerializeSortOrder() => SortOrder is not null && ShouldSerialize(SortOrder);
  public bool ShouldSerializeShowAllSources() => ShowAllSources == true;
}
