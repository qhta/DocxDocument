namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a built-in document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuiltinproperty?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdBuiltInProperty))]
public enum BuiltInProperty
{
  /// <summary>
  /// Title.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyTitle))]
  Title = 1,
  /// <summary>
  /// Subject.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertySubject))]
  Subject = 2,
  /// <summary>
  /// Author.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyAuthor))]
  Author = 3,
  /// <summary>
  /// Keywords.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyKeywords))]
  Keywords = 4,
  /// <summary>
  /// Comments.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyComments))]
  Comments = 5,
  /// <summary>
  /// Template name.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyTemplate))]
  Template = 6,
  /// <summary>
  /// Last author.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyLastAuthor))]
  LastAuthor = 7,
  /// <summary>
  /// Revision number.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyRevision))]
  Revision = 8,
  /// <summary>
  /// Name of application.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyAppName))]
  AppName = 9,
  /// <summary>
  /// Time last printed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyTimeLastPrinted))]
  TimeLastPrinted = 10,
  /// <summary>
  /// Time created.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyTimeCreated))]
  TimeCreated = 11,
  /// <summary>
  /// Time last saved.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyTimeLastSaved))]
  TimeLastSaved = 12,
  /// <summary>
  /// Number of edits to VBA project.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyVBATotalEdit))]
  VBATotalEdit = 13,
  /// <summary>
  /// Page count.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyPages))]
  Pages = 14,
  /// <summary>
  /// Word count.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyWords))]
  Words = 15,
  /// <summary>
  /// Character count.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyCharacters))]
  Characters = 16,
  /// <summary>
  /// Security setting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertySecurity))]
  Security = 17,
  /// <summary>
  /// Category.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyCategory))]
  Category = 18,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyFormat))]
  Format = 19,
  /// <summary>
  /// Manager.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyManager))]
  Manager = 20,
  /// <summary>
  /// Company.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyCompany))]
  Company = 21,
  /// <summary>
  /// Byte count.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyBytes))]
  Bytes = 22,
  /// <summary>
  /// Line count.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyLines))]
  Lines = 23,
  /// <summary>
  /// Paragraph count.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyParas))]
  Paras = 24,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertySlides))]
  Slides = 25,
  /// <summary>
  /// Notes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyNotes))]
  Notes = 26,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyHiddenSlides))]
  HiddenSlides = 27,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyMMClips))]
  MMClips = 28,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyHyperlinkBase))]
  HyperlinkBase = 29,
  /// <summary>
  /// Character count with spaces.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltInProperty.wdPropertyCharsWSpaces))]
  CharsWSpaces = 30
}
