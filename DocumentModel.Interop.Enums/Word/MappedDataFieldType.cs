namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a type of mapped data field.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmappeddatafields?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdMappedDataFields))]
public enum MappedDataFieldType
{
  /// <summary>
  /// Unique identifier field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdUniqueIdentifier))]
  UniqueIdentifier = 1,
  /// <summary>
  /// Courtesy title field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdCourtesyTitle))]
  CourtesyTitle = 2,
  /// <summary>
  /// First name field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdFirstName))]
  FirstName = 3,
  /// <summary>
  /// Middle name field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdMiddleName))]
  MiddleName = 4,
  /// <summary>
  /// Last name field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdLastName))]
  LastName = 5,
  /// <summary>
  /// Suffix field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdSuffix))]
  Suffix = 6,
  /// <summary>
  /// Nickname field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdNickname))]
  Nickname = 7,
  /// <summary>
  /// Job title field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdJobTitle))]
  JobTitle = 8,
  /// <summary>
  /// Company field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdCompany))]
  Company = 9,
  /// <summary>
  /// Address 1 field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdAddress1))]
  Address1 = 10,
  /// <summary>
  /// Address 2 field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdAddress2))]
  Address2 = 11,
  /// <summary>
  /// City field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdCity))]
  City = 12,
  /// <summary>
  /// State field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdState))]
  State = 13,
  /// <summary>
  /// Postal code field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdPostalCode))]
  PostalCode = 14,
  /// <summary>
  /// Country/region field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdCountryRegion))]
  CountryRegion = 15,
  /// <summary>
  /// Business phone field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdBusinessPhone))]
  BusinessPhone = 16,
  /// <summary>
  /// Business fax field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdBusinessFax))]
  BusinessFax = 17,
  /// <summary>
  /// Home phone field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdHomePhone))]
  HomePhone = 18,
  /// <summary>
  /// Home fax field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdHomeFax))]
  HomeFax = 19,
  /// <summary>
  /// E-mail address field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdEmailAddress))]
  EmailAddress = 20,
  /// <summary>
  /// Web page unique resource identifier (URL) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdWebPageURL))]
  WebPageURL = 21,
  /// <summary>
  /// Spouse courtesy title field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdSpouseCourtesyTitle))]
  SpouseCourtesyTitle = 22,
  /// <summary>
  /// Spouse first name field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdSpouseFirstName))]
  SpouseFirstName = 23,
  /// <summary>
  /// Spouse middle name field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdSpouseMiddleName))]
  SpouseMiddleName = 24,
  /// <summary>
  /// Spouse last name field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdSpouseLastName))]
  SpouseLastName = 25,
  /// <summary>
  /// Spouse nickname field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdSpouseNickname))]
  SpouseNickname = 26,
  /// <summary>
  /// Ruby first name field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdRubyFirstName))]
  RubyFirstName = 27,
  /// <summary>
  /// Ruby last name field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdRubyLastName))]
  RubyLastName = 28,
  /// <summary>
  /// Address 3 field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdAddress3))]
  Address3 = 29,
  /// <summary>
  /// Department field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMappedDataFields.wdDepartment))]
  Department = 30
}
