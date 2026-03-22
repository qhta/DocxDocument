namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Source
{
  public bool ShouldSerializeTag() => Tag is not null;
  public bool ShouldSerializeSourceType() => SourceType is not null;
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeAuthors() => Authors is not null;
  public bool ShouldSerializeEditors() => Editors is not null;
  public bool ShouldSerializeContributors() => Contributors is not null;
  public bool ShouldSerializeYear() => Year is not null;
  public bool ShouldSerializeMonth() => Month is not null;
  public bool ShouldSerializeDay() => Day is not null;
  public bool ShouldSerializePublisher() => Publisher is not null;
  public bool ShouldSerializeCity() => City is not null;
  public bool ShouldSerializeStateProvince() => StateProvince is not null;
  public bool ShouldSerializeCountryRegion() => CountryRegion is not null;
  public bool ShouldSerializeVolume() => Volume is not null;
  public bool ShouldSerializeIssue() => Issue is not null;
  public bool ShouldSerializePages() => Pages is not null;
  public bool ShouldSerializeEdition() => Edition is not null;
  public bool ShouldSerializeUrl() => Url is not null;
  public bool ShouldSerializeAccessDate() => AccessDate is not null;
  public bool ShouldSerializeDOI() => DOI is not null;
  public bool ShouldSerializeISBN() => ISBN is not null;
  public bool ShouldSerializeISSN() => ISSN is not null;
  public bool ShouldSerializeAbstract() => Abstract is not null;
  public bool ShouldSerializeComments() => Comments is not null;
  public bool ShouldSerializeKeywords() => Keywords is not null;
  public bool ShouldSerializeLanguage() => Language is not null;
  public bool ShouldSerializeIsCorporateAuthor() => IsCorporateAuthor == true;
  public bool ShouldSerializeXml() => Xml is not null;
}
