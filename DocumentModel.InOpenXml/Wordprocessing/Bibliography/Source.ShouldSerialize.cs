namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Source
{
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeSourceType() => SourceType is not null && ShouldSerialize(SourceType);
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeAuthors() => Authors is not null && ShouldSerialize(Authors);
  public bool ShouldSerializeEditors() => Editors is not null && ShouldSerialize(Editors);
  public bool ShouldSerializeContributors() => Contributors is not null && ShouldSerialize(Contributors);
  public bool ShouldSerializeYear() => !String.IsNullOrEmpty(Year);
  public bool ShouldSerializeMonth() => !String.IsNullOrEmpty(Month);
  public bool ShouldSerializeDay() => !String.IsNullOrEmpty(Day);
  public bool ShouldSerializePublisher() => !String.IsNullOrEmpty(Publisher);
  public bool ShouldSerializeCity() => !String.IsNullOrEmpty(City);
  public bool ShouldSerializeStateProvince() => !String.IsNullOrEmpty(StateProvince);
  public bool ShouldSerializeCountryRegion() => !String.IsNullOrEmpty(CountryRegion);
  public bool ShouldSerializeVolume() => !String.IsNullOrEmpty(Volume);
  public bool ShouldSerializeIssue() => !String.IsNullOrEmpty(Issue);
  public bool ShouldSerializePages() => !String.IsNullOrEmpty(Pages);
  public bool ShouldSerializeEdition() => !String.IsNullOrEmpty(Edition);
  public bool ShouldSerializeUrl() => !String.IsNullOrEmpty(Url);
  public bool ShouldSerializeAccessDate() => AccessDate is not null && ShouldSerialize(AccessDate);
  public bool ShouldSerializeDOI() => !String.IsNullOrEmpty(DOI);
  public bool ShouldSerializeISBN() => !String.IsNullOrEmpty(ISBN);
  public bool ShouldSerializeISSN() => !String.IsNullOrEmpty(ISSN);
  public bool ShouldSerializeAbstract() => !String.IsNullOrEmpty(Abstract);
  public bool ShouldSerializeComments() => !String.IsNullOrEmpty(Comments);
  public bool ShouldSerializeKeywords() => !String.IsNullOrEmpty(Keywords);
  public bool ShouldSerializeLanguage() => !String.IsNullOrEmpty(Language);
  public bool ShouldSerializeIsCorporateAuthor() => IsCorporateAuthor == true;
  public bool ShouldSerializeXml() => !String.IsNullOrEmpty(Xml);
}
