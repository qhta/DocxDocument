namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of mapped data field.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmappeddatafields?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMappedDataFields")]
public enum MappedDataFieldType
{
  /// <summary>
  /// Unique identifier field.
  /// </summary>
  [InteropEnumValue("wdUniqueIdentifier")]
  UniqueIdentifier = 1,
  /// <summary>
  /// Courtesy title field.
  /// </summary>
  [InteropEnumValue("wdCourtesyTitle")]
  CourtesyTitle = 2,
  /// <summary>
  /// First name field.
  /// </summary>
  [InteropEnumValue("wdFirstName")]
  FirstName = 3,
  /// <summary>
  /// Middle name field.
  /// </summary>
  [InteropEnumValue("wdMiddleName")]
  MiddleName = 4,
  /// <summary>
  /// Last name field.
  /// </summary>
  [InteropEnumValue("wdLastName")]
  LastName = 5,
  /// <summary>
  /// Suffix field.
  /// </summary>
  [InteropEnumValue("wdSuffix")]
  Suffix = 6,
  /// <summary>
  /// Nickname field.
  /// </summary>
  [InteropEnumValue("wdNickname")]
  Nickname = 7,
  /// <summary>
  /// Job title field.
  /// </summary>
  [InteropEnumValue("wdJobTitle")]
  JobTitle = 8,
  /// <summary>
  /// Company field.
  /// </summary>
  [InteropEnumValue("wdCompany")]
  Company = 9,
  /// <summary>
  /// Address 1 field.
  /// </summary>
  [InteropEnumValue("wdAddress1")]
  Address1 = 10,
  /// <summary>
  /// Address 2 field.
  /// </summary>
  [InteropEnumValue("wdAddress2")]
  Address2 = 11,
  /// <summary>
  /// City field.
  /// </summary>
  [InteropEnumValue("wdCity")]
  City = 12,
  /// <summary>
  /// State field.
  /// </summary>
  [InteropEnumValue("wdState")]
  State = 13,
  /// <summary>
  /// Postal code field.
  /// </summary>
  [InteropEnumValue("wdPostalCode")]
  PostalCode = 14,
  /// <summary>
  /// Country/region field.
  /// </summary>
  [InteropEnumValue("wdCountryRegion")]
  CountryRegion = 15,
  /// <summary>
  /// Business phone field.
  /// </summary>
  [InteropEnumValue("wdBusinessPhone")]
  BusinessPhone = 16,
  /// <summary>
  /// Business fax field.
  /// </summary>
  [InteropEnumValue("wdBusinessFax")]
  BusinessFax = 17,
  /// <summary>
  /// Home phone field.
  /// </summary>
  [InteropEnumValue("wdHomePhone")]
  HomePhone = 18,
  /// <summary>
  /// Home fax field.
  /// </summary>
  [InteropEnumValue("wdHomeFax")]
  HomeFax = 19,
  /// <summary>
  /// E-mail address field.
  /// </summary>
  [InteropEnumValue("wdEmailAddress")]
  EmailAddress = 20,
  /// <summary>
  /// Web page unique resource identifier (URL) field.
  /// </summary>
  [InteropEnumValue("wdWebPageURL")]
  WebPageURL = 21,
  /// <summary>
  /// Spouse courtesy title field.
  /// </summary>
  [InteropEnumValue("wdSpouseCourtesyTitle")]
  SpouseCourtesyTitle = 22,
  /// <summary>
  /// Spouse first name field.
  /// </summary>
  [InteropEnumValue("wdSpouseFirstName")]
  SpouseFirstName = 23,
  /// <summary>
  /// Spouse middle name field.
  /// </summary>
  [InteropEnumValue("wdSpouseMiddleName")]
  SpouseMiddleName = 24,
  /// <summary>
  /// Spouse last name field.
  /// </summary>
  [InteropEnumValue("wdSpouseLastName")]
  SpouseLastName = 25,
  /// <summary>
  /// Spouse nickname field.
  /// </summary>
  [InteropEnumValue("wdSpouseNickname")]
  SpouseNickname = 26,
  /// <summary>
  /// Ruby first name field.
  /// </summary>
  [InteropEnumValue("wdRubyFirstName")]
  RubyFirstName = 27,
  /// <summary>
  /// Ruby last name field.
  /// </summary>
  [InteropEnumValue("wdRubyLastName")]
  RubyLastName = 28,
  /// <summary>
  /// Address 3 field.
  /// </summary>
  [InteropEnumValue("wdAddress3")]
  Address3 = 29,
  /// <summary>
  /// Department field.
  /// </summary>
  [InteropEnumValue("wdDepartment")]
  Department = 30
}
