namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a Microsoft Word field.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdFieldType
{
  /// <summary>
  /// Ref field.
  /// </summary>
  Ref = 3,
  /// <summary>
  /// XE (Index Entry) field.
  /// </summary>
  IndexEntry = 4,
  /// <summary>
  /// FootnoteRef field. Not available through the Field dialog box. Inserted programmatically or interactively.
  /// </summary>
  FootnoteRef = 5,
  /// <summary>
  /// Set field.
  /// </summary>
  Set = 6,
  /// <summary>
  /// If field.
  /// </summary>
  If = 7,
  /// <summary>
  /// Index field.
  /// </summary>
  Index = 8,
  /// <summary>
  /// TOC (Table of Contents Entry) field.
  /// </summary>
  TOCEntry = 9,
  /// <summary>
  /// StyleRef field.
  /// </summary>
  StyleRef = 10,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  RefDoc = 11,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Sequence = 12,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  TOC = 13,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Info = 14,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Title = 15,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Subject = 16,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Author = 17,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  KeyWord = 18,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Comments = 19,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  LastSavedBy = 20,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  CreateDate = 21,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  SaveDate = 22,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  PrintDate = 23,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  RevisionNum = 24,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  EditTime = 25,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  NumPages = 26,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  NumWords = 27,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  NumChars = 28,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  FileName = 29,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Template = 30,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Date = 31,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Time = 32,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Page = 33,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Expression = 34,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Quote = 35,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Include = 36,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  PageRef = 37,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Ask = 38,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  FillIn = 39,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Data = 40,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Next = 41,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  NextIf = 42,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  SkipIf = 43,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  MergeRec = 44,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  DDE = 45,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  DDEAuto = 46,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Glossary = 47,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Print = 48,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Formula = 49,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  GoToButton = 50,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  MacroButton = 51,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AutoNumOutline = 52,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AutoNumLegal = 53,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AutoNum = 54,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Import = 55,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Link = 56,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Symbol = 57,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Embed = 58,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  MergeField = 59,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  UserName = 60,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  UserInitials = 61,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  UserAddress = 62,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  BarCode = 63,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  DocVariable = 64,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Section = 65,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  SectionPages = 66,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  IncludePicture = 67,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  IncludeText = 68,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  FileSize = 69,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  FormTextInput = 70,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  FormCheckBox = 71,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  NoteRef = 72,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  TOA = 73,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  TOAEntry = 74,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  MergeSeq = 75,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Private = 77,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Database = 78,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AutoText = 79,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Compare = 80,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Addin = 81,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Subscriber = 82,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  FormDropDown = 83,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Advance = 84,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  DocProperty = 85,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  OCX = 87,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Hyperlink = 88,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AutoTextList = 89,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  ListNum = 90,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  HTMLActiveX = 91,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  BidiOutline = 92,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AddressBlock = 93,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  GreetingLine = 94,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Shape = 95,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Citation = 96,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Bibliography = 97,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  MergeBarcode = 98,
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  DisplayBarcode = 99,
  /// <summary>
  /// Empty field. Acts as a placeholder for field content that has not yet been added. A field added by pressing
  /// Ctrl+F9 in the user interface is an Empty field.
  /// </summary>
  Empty = -1
}
