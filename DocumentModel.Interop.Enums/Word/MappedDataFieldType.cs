namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of mapped data field.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmappeddatafields?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMappedDataFields")]
public enum MappedDataFieldType
{
  /// <summary>
  /// Unique identifier field.
  /// </summary>
  [WordInteropEnumValue("wdUniqueIdentifier")]
  UniqueIdentifier = 1,
  /// <summary>
  /// Courtesy title field.
  /// </summary>
  [WordInteropEnumValue("wdCourtesyTitle")]
  CourtesyTitle = 2,
  /// <summary>
  /// First name field.
  /// </summary>
  [WordInteropEnumValue("wdFirstName")]
  FirstName = 3,
  /// <summary>
  /// Middle name field.
  /// </summary>
  [WordInteropEnumValue("wdMiddleName")]
  MiddleName = 4,
  /// <summary>
  /// Last name field.
  /// </summary>
  [WordInteropEnumValue("wdLastName")]
  LastName = 5,
  /// <summary>
  /// Suffix field.
  /// </summary>
  [WordInteropEnumValue("wdSuffix")]
  Suffix = 6,
  /// <summary>
  /// Nickname field.
  /// </summary>
  [WordInteropEnumValue("wdNickname")]
  Nickname = 7,
  /// <summary>
  /// Job title field.
  /// </summary>
  [WordInteropEnumValue("wdJobTitle")]
  JobTitle = 8,
  /// <summary>
  /// Company field.
  /// </summary>
  [WordInteropEnumValue("wdCompany")]
  Company = 9,
  /// <summary>
  /// Address 1 field.
  /// </summary>
  [WordInteropEnumValue("wdAddress1")]
  Address1 = 10,
  /// <summary>
  /// Address 2 field.
  /// </summary>
  [WordInteropEnumValue("wdAddress2")]
  Address2 = 11,
  /// <summary>
  /// City field.
  /// </summary>
  [WordInteropEnumValue("wdCity")]
  City = 12,
  /// <summary>
  /// State field.
  /// </summary>
  [WordInteropEnumValue("wdState")]
  State = 13,
  /// <summary>
  /// Postal code field.
  /// </summary>
  [WordInteropEnumValue("wdPostalCode")]
  PostalCode = 14,
  /// <summary>
  /// Country/region field.
  /// </summary>
  [WordInteropEnumValue("wdCountryRegion")]
  CountryRegion = 15,
  /// <summary>
  /// Business phone field.
  /// </summary>
  [WordInteropEnumValue("wdBusinessPhone")]
  BusinessPhone = 16,
  /// <summary>
  /// Business fax field.
  /// </summary>
  [WordInteropEnumValue("wdBusinessFax")]
  BusinessFax = 17,
  /// <summary>
  /// Home phone field.
  /// </summary>
  [WordInteropEnumValue("wdHomePhone")]
  HomePhone = 18,
  /// <summary>
  /// Home fax field.
  /// </summary>
  [WordInteropEnumValue("wdHomeFax")]
  HomeFax = 19,
  /// <summary>
  /// E-mail address field.
  /// </summary>
  [WordInteropEnumValue("wdEmailAddress")]
  EmailAddress = 20,
  /// <summary>
  /// Web page unique resource identifier (URL) field.
  /// </summary>
  [WordInteropEnumValue("wdWebPageURL")]
  WebPageURL = 21,
  /// <summary>
  /// Spouse courtesy title field.
  /// </summary>
  [WordInteropEnumValue("wdSpouseCourtesyTitle")]
  SpouseCourtesyTitle = 22,
  /// <summary>
  /// Spouse first name field.
  /// </summary>
  [WordInteropEnumValue("wdSpouseFirstName")]
  SpouseFirstName = 23,
  /// <summary>
  /// Spouse middle name field.
  /// </summary>
  [WordInteropEnumValue("wdSpouseMiddleName")]
  SpouseMiddleName = 24,
  /// <summary>
  /// Spouse last name field.
  /// </summary>
  [WordInteropEnumValue("wdSpouseLastName")]
  SpouseLastName = 25,
  /// <summary>
  /// Spouse nickname field.
  /// </summary>
  [WordInteropEnumValue("wdSpouseNickname")]
  SpouseNickname = 26,
  /// <summary>
  /// Ruby first name field.
  /// </summary>
  [WordInteropEnumValue("wdRubyFirstName")]
  RubyFirstName = 27,
  /// <summary>
  /// Ruby last name field.
  /// </summary>
  [WordInteropEnumValue("wdRubyLastName")]
  RubyLastName = 28,
  /// <summary>
  /// Address 3 field.
  /// </summary>
  [WordInteropEnumValue("wdAddress3")]
  Address3 = 29,
  /// <summary>
  /// Department field.
  /// </summary>
  [WordInteropEnumValue("wdDepartment")]
  Department = 30
}
