namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a built-in document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuiltinproperty?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdBuiltInProperty")]
public enum BuiltInProperty
{
  /// <summary>
  /// Title.
  /// </summary>
  [WordInteropEnumValue("wdPropertyTitle")]
  Title = 1,
  /// <summary>
  /// Subject.
  /// </summary>
  [WordInteropEnumValue("wdPropertySubject")]
  Subject = 2,
  /// <summary>
  /// Author.
  /// </summary>
  [WordInteropEnumValue("wdPropertyAuthor")]
  Author = 3,
  /// <summary>
  /// Keywords.
  /// </summary>
  [WordInteropEnumValue("wdPropertyKeywords")]
  Keywords = 4,
  /// <summary>
  /// Comments.
  /// </summary>
  [WordInteropEnumValue("wdPropertyComments")]
  Comments = 5,
  /// <summary>
  /// Template name.
  /// </summary>
  [WordInteropEnumValue("wdPropertyTemplate")]
  Template = 6,
  /// <summary>
  /// Last author.
  /// </summary>
  [WordInteropEnumValue("wdPropertyLastAuthor")]
  LastAuthor = 7,
  /// <summary>
  /// Revision number.
  /// </summary>
  [WordInteropEnumValue("wdPropertyRevision")]
  Revision = 8,
  /// <summary>
  /// Name of application.
  /// </summary>
  [WordInteropEnumValue("wdPropertyAppName")]
  AppName = 9,
  /// <summary>
  /// Time last printed.
  /// </summary>
  [WordInteropEnumValue("wdPropertyTimeLastPrinted")]
  TimeLastPrinted = 10,
  /// <summary>
  /// Time created.
  /// </summary>
  [WordInteropEnumValue("wdPropertyTimeCreated")]
  TimeCreated = 11,
  /// <summary>
  /// Time last saved.
  /// </summary>
  [WordInteropEnumValue("wdPropertyTimeLastSaved")]
  TimeLastSaved = 12,
  /// <summary>
  /// Number of edits to VBA project.
  /// </summary>
  [WordInteropEnumValue("wdPropertyVBATotalEdit")]
  VBATotalEdit = 13,
  /// <summary>
  /// Page count.
  /// </summary>
  [WordInteropEnumValue("wdPropertyPages")]
  Pages = 14,
  /// <summary>
  /// Word count.
  /// </summary>
  [WordInteropEnumValue("wdPropertyWords")]
  Words = 15,
  /// <summary>
  /// Character count.
  /// </summary>
  [WordInteropEnumValue("wdPropertyCharacters")]
  Characters = 16,
  /// <summary>
  /// Security setting.
  /// </summary>
  [WordInteropEnumValue("wdPropertySecurity")]
  Security = 17,
  /// <summary>
  /// Category.
  /// </summary>
  [WordInteropEnumValue("wdPropertyCategory")]
  Category = 18,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPropertyFormat")]
  Format = 19,
  /// <summary>
  /// Manager.
  /// </summary>
  [WordInteropEnumValue("wdPropertyManager")]
  Manager = 20,
  /// <summary>
  /// Company.
  /// </summary>
  [WordInteropEnumValue("wdPropertyCompany")]
  Company = 21,
  /// <summary>
  /// Byte count.
  /// </summary>
  [WordInteropEnumValue("wdPropertyBytes")]
  Bytes = 22,
  /// <summary>
  /// Line count.
  /// </summary>
  [WordInteropEnumValue("wdPropertyLines")]
  Lines = 23,
  /// <summary>
  /// Paragraph count.
  /// </summary>
  [WordInteropEnumValue("wdPropertyParas")]
  Paras = 24,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPropertySlides")]
  Slides = 25,
  /// <summary>
  /// Notes.
  /// </summary>
  [WordInteropEnumValue("wdPropertyNotes")]
  Notes = 26,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPropertyHiddenSlides")]
  HiddenSlides = 27,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPropertyMMClips")]
  MMClips = 28,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPropertyHyperlinkBase")]
  HyperlinkBase = 29,
  /// <summary>
  /// Character count with spaces.
  /// </summary>
  [WordInteropEnumValue("wdPropertyCharsWSpaces")]
  CharsWSpaces = 30
}
