namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a built-in document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuiltinproperty?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdBuiltInProperty")]
public enum BuiltInProperty
{
  /// <summary>
  /// Title.
  /// </summary>
  [InteropEnumValue("wdPropertyTitle")]
  Title = 1,
  /// <summary>
  /// Subject.
  /// </summary>
  [InteropEnumValue("wdPropertySubject")]
  Subject = 2,
  /// <summary>
  /// Author.
  /// </summary>
  [InteropEnumValue("wdPropertyAuthor")]
  Author = 3,
  /// <summary>
  /// Keywords.
  /// </summary>
  [InteropEnumValue("wdPropertyKeywords")]
  Keywords = 4,
  /// <summary>
  /// Comments.
  /// </summary>
  [InteropEnumValue("wdPropertyComments")]
  Comments = 5,
  /// <summary>
  /// Template name.
  /// </summary>
  [InteropEnumValue("wdPropertyTemplate")]
  Template = 6,
  /// <summary>
  /// Last author.
  /// </summary>
  [InteropEnumValue("wdPropertyLastAuthor")]
  LastAuthor = 7,
  /// <summary>
  /// Revision number.
  /// </summary>
  [InteropEnumValue("wdPropertyRevision")]
  Revision = 8,
  /// <summary>
  /// Name of application.
  /// </summary>
  [InteropEnumValue("wdPropertyAppName")]
  AppName = 9,
  /// <summary>
  /// Time last printed.
  /// </summary>
  [InteropEnumValue("wdPropertyTimeLastPrinted")]
  TimeLastPrinted = 10,
  /// <summary>
  /// Time created.
  /// </summary>
  [InteropEnumValue("wdPropertyTimeCreated")]
  TimeCreated = 11,
  /// <summary>
  /// Time last saved.
  /// </summary>
  [InteropEnumValue("wdPropertyTimeLastSaved")]
  TimeLastSaved = 12,
  /// <summary>
  /// Number of edits to VBA project.
  /// </summary>
  [InteropEnumValue("wdPropertyVBATotalEdit")]
  VBATotalEdit = 13,
  /// <summary>
  /// Page count.
  /// </summary>
  [InteropEnumValue("wdPropertyPages")]
  Pages = 14,
  /// <summary>
  /// Word count.
  /// </summary>
  [InteropEnumValue("wdPropertyWords")]
  Words = 15,
  /// <summary>
  /// Character count.
  /// </summary>
  [InteropEnumValue("wdPropertyCharacters")]
  Characters = 16,
  /// <summary>
  /// Security setting.
  /// </summary>
  [InteropEnumValue("wdPropertySecurity")]
  Security = 17,
  /// <summary>
  /// Category.
  /// </summary>
  [InteropEnumValue("wdPropertyCategory")]
  Category = 18,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdPropertyFormat")]
  Format = 19,
  /// <summary>
  /// Manager.
  /// </summary>
  [InteropEnumValue("wdPropertyManager")]
  Manager = 20,
  /// <summary>
  /// Company.
  /// </summary>
  [InteropEnumValue("wdPropertyCompany")]
  Company = 21,
  /// <summary>
  /// Byte count.
  /// </summary>
  [InteropEnumValue("wdPropertyBytes")]
  Bytes = 22,
  /// <summary>
  /// Line count.
  /// </summary>
  [InteropEnumValue("wdPropertyLines")]
  Lines = 23,
  /// <summary>
  /// Paragraph count.
  /// </summary>
  [InteropEnumValue("wdPropertyParas")]
  Paras = 24,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdPropertySlides")]
  Slides = 25,
  /// <summary>
  /// Notes.
  /// </summary>
  [InteropEnumValue("wdPropertyNotes")]
  Notes = 26,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdPropertyHiddenSlides")]
  HiddenSlides = 27,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdPropertyMMClips")]
  MMClips = 28,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdPropertyHyperlinkBase")]
  HyperlinkBase = 29,
  /// <summary>
  /// Character count with spaces.
  /// </summary>
  [InteropEnumValue("wdPropertyCharsWSpaces")]
  CharsWSpaces = 30
}
