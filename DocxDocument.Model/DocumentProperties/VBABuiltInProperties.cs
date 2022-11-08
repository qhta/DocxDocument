namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum VBABuiltInProperties
{
  /// <summary> 
  /// Title.
  ///</summary> 
  Title = 1,

  /// <summary> 
  /// Subject.
  ///</summary> 
  Subject = 2,

  /// <summary> 
  /// Author.
  ///</summary> 
  Author = 3,

  /// <summary> 
  /// Keywords.
  ///</summary> 
  Keywords = 4,

  /// <summary> 
  /// Comments.
  ///</summary> 
  Comments = 5,

  /// <summary> 
  /// Template name.
  ///</summary> 
  Template = 6,

  /// <summary> 
  /// Last author.
  ///</summary> 
  LastAuthor = 7,

  /// <summary> 
  /// Revision number.
  ///</summary> 
  Revision = 8,

  /// <summary> 
  /// Name of application.
  ///</summary> 
  AppName = 9,

  /// <summary> 
  /// Time last printed.
  ///</summary> 
  TimeLastPrinted = 10,

  /// <summary> 
  /// Time created.
  ///</summary> 
  TimeCreated = 11,

  /// <summary> 
  /// Time last saved.
  ///</summary> 
  TimeLastSaved = 12,

  /// <summary> 
  /// Number of edits to VBA project.
  ///</summary> 
  VBATotalEdit = 13,

  /// <summary> 
  /// Page count.
  ///</summary> 
  Pages = 14,

  /// <summary> 
  /// Word count.
  ///</summary> 
  Words = 15,

  /// <summary> 
  /// Character count.
  ///</summary> 
  Characters = 16,

  /// <summary> 
  /// Security setting.
  ///</summary> 
  Security = 17,

  /// <summary> 
  /// Category.
  ///</summary> 
  Category = 18,

  /// <summary> 
  /// Not supported.
  ///</summary> 
  Format = 19,

  /// <summary> 
  /// Manager.
  ///</summary> 
  Manager = 20,

  /// <summary> 
  /// Company.
  ///</summary> 
  Company = 21,

  /// <summary> 
  /// Byte count.
  ///</summary> 
  Bytes = 22,

  /// <summary> 
  /// Line count.
  ///</summary> 
  Lines = 23,

  /// <summary> 
  /// Paragraph count.
  ///</summary> 
  Paras = 24,

  /// <summary> 
  /// Not supported.
  ///</summary> 
  Slides = 25,

  /// <summary> 
  /// Notes.
  ///</summary> 
  Notes = 26,

  /// <summary> 
  /// Not supported.
  ///</summary> 
  HiddenSlides = 27,

  /// <summary> 
  /// Not supported.
  ///</summary> 
  MMClips = 28,

  /// <summary> 
  /// Not supported.
  ///</summary> 
  HyperlinkBase = 29,

  /// <summary> 
  /// Character count with spaces.
  ///</summary> 
  CharsWSpaces = 30,


}