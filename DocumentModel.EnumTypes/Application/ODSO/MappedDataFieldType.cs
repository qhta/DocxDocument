namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a type of mapped data field.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmappeddatafields?view=office-pia` for Office interop details.
/// </remarks>
public enum MappedDataFieldType
{
  /// <summary>
  /// Unique identifier field.
  /// </summary>
  UniqueIdentifier = 1,
  /// <summary>
  /// Courtesy title field.
  /// </summary>
  CourtesyTitle = 2,
  /// <summary>
  /// First name field.
  /// </summary>
  FirstName = 3,
  /// <summary>
  /// Middle name field.
  /// </summary>
  MiddleName = 4,
  /// <summary>
  /// Last name field.
  /// </summary>
  LastName = 5,
  /// <summary>
  /// Suffix field.
  /// </summary>
  Suffix = 6,
  /// <summary>
  /// Nickname field.
  /// </summary>
  Nickname = 7,
  /// <summary>
  /// Job title field.
  /// </summary>
  JobTitle = 8,
  /// <summary>
  /// Company field.
  /// </summary>
  Company = 9,
  /// <summary>
  /// Address 1 field.
  /// </summary>
  Address1 = 10,
  /// <summary>
  /// Address 2 field.
  /// </summary>
  Address2 = 11,
  /// <summary>
  /// City field.
  /// </summary>
  City = 12,
  /// <summary>
  /// State field.
  /// </summary>
  State = 13,
  /// <summary>
  /// Postal code field.
  /// </summary>
  PostalCode = 14,
  /// <summary>
  /// Country/region field.
  /// </summary>
  CountryRegion = 15,
  /// <summary>
  /// Business phone field.
  /// </summary>
  BusinessPhone = 16,
  /// <summary>
  /// Business fax field.
  /// </summary>
  BusinessFax = 17,
  /// <summary>
  /// Home phone field.
  /// </summary>
  HomePhone = 18,
  /// <summary>
  /// Home fax field.
  /// </summary>
  HomeFax = 19,
  /// <summary>
  /// E-mail address field.
  /// </summary>
  EmailAddress = 20,
  /// <summary>
  /// Web page unique resource identifier (URL) field.
  /// </summary>
  WebPageURL = 21,
  /// <summary>
  /// Spouse courtesy title field.
  /// </summary>
  SpouseCourtesyTitle = 22,
  /// <summary>
  /// Spouse first name field.
  /// </summary>
  SpouseFirstName = 23,
  /// <summary>
  /// Spouse middle name field.
  /// </summary>
  SpouseMiddleName = 24,
  /// <summary>
  /// Spouse last name field.
  /// </summary>
  SpouseLastName = 25,
  /// <summary>
  /// Spouse nickname field.
  /// </summary>
  SpouseNickname = 26,
  /// <summary>
  /// Ruby first name field.
  /// </summary>
  RubyFirstName = 27,
  /// <summary>
  /// Ruby last name field.
  /// </summary>
  RubyLastName = 28,
  /// <summary>
  /// Address 3 field.
  /// </summary>
  Address3 = 29,
  /// <summary>
  /// Department field.
  /// </summary>
  Department = 30
}
