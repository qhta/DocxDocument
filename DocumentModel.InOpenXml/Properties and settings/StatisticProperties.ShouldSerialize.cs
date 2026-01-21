namespace DocumentModel;

public partial class StatisticProperties
{
  public bool ShouldSerializePages() => Pages is not null;
  public bool ShouldSerializeWords() => Words is not null;
  public bool ShouldSerializeCharacters() => Characters is not null;
  public bool ShouldSerializeLines() => Lines is not null;
  public bool ShouldSerializeParagraphs() => Paragraphs is not null;
  public bool ShouldSerializeCharactersWithSpaces() => CharactersWithSpaces is not null;
  public bool ShouldSerializeSlides() => Slides is not null;
  public bool ShouldSerializeNotes() => Notes is not null;
  public bool ShouldSerializeHiddenSlides() => HiddenSlides is not null;
  public bool ShouldSerializeMultimediaClips() => MultimediaClips is not null;
  public bool ShouldSerializeTotalTime() => TotalTime is not null;
}
