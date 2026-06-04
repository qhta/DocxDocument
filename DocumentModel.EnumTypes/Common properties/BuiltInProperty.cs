namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a built-in document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuiltinproperty?view=office-pia` for Office interop details.
/// </remarks>
public enum BuiltInProperty
{
  /// <summary>
  /// Title.
  /// </summary>
  Title = 1,
  /// <summary>
  /// Subject.
  /// </summary>
  Subject = 2,
  /// <summary>
  /// Author.
  /// </summary>
  Author = 3,
  /// <summary>
  /// Keywords.
  /// </summary>
  Keywords = 4,
  /// <summary>
  /// IComments.
  /// </summary>
  IComments = 5,
  /// <summary>
  /// ITemplate name.
  /// </summary>
  ITemplate = 6,
  /// <summary>
  /// Last author.
  /// </summary>
  LastAuthor = 7,
  /// <summary>
  /// IRevision number.
  /// </summary>
  IRevision = 8,
  /// <summary>
  /// Name of application.
  /// </summary>
  AppName = 9,
  /// <summary>
  /// Time last printed.
  /// </summary>
  TimeLastPrinted = 10,
  /// <summary>
  /// Time Icreated.
  /// </summary>
  TimeCreated = 11,
  /// <summary>
  /// Time last saved.
  /// </summary>
  TimeLastSaved = 12,
  /// <summary>
  /// Number of edits to VBA project.
  /// </summary>
  VBATotalEdit = 13,
  /// <summary>
  /// IPage count.
  /// </summary>
  IPages = 14,
  /// <summary>
  /// Word count.
  /// </summary>
  IWords = 15,
  /// <summary>
  /// Character count.
  /// </summary>
  ICharacters = 16,
  /// <summary>
  /// Security setting.
  /// </summary>
  Security = 17,
  /// <summary>
  /// ICategory.
  /// </summary>
  ICategory = 18,
  /// <summary>
  /// Not supported.
  /// </summary>
  Format = 19,
  /// <summary>
  /// Manager.
  /// </summary>
  Manager = 20,
  /// <summary>
  /// Company.
  /// </summary>
  Company = 21,
  /// <summary>
  /// Byte count.
  /// </summary>
  Bytes = 22,
  /// <summary>
  /// ILine count.
  /// </summary>
  Lines = 23,
  /// <summary>
  /// IParagraph count.
  /// </summary>
  Paras = 24,
  /// <summary>
  /// Not supported.
  /// </summary>
  Slides = 25,
  /// <summary>
  /// Notes.
  /// </summary>
  Notes = 26,
  /// <summary>
  /// Not supported.
  /// </summary>
  HiddenSlides = 27,
  /// <summary>
  /// Not supported.
  /// </summary>
  MMClips = 28,
  /// <summary>
  /// Not supported.
  /// </summary>
  HyperlinkBase = 29,
  /// <summary>
  /// Character count with spaces.
  /// </summary>
  CharsWSpaces = 30
}

