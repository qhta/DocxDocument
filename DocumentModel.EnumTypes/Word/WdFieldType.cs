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
  /// RD (Reference Document) field.
  /// </summary>
  RefDoc = 11,
  /// <summary>
  /// Seq (Sequence) field.
  /// </summary>
  Sequence = 12,
  /// <summary>
  /// TOC (Table of Contents) field.
  /// </summary>
  TOC = 13,
  /// <summary>
  /// Info field.
  /// </summary>
  Info = 14,
  /// <summary>
  /// Title field.
  /// </summary>
  Title = 15,
  /// <summary>
  /// Subject field.
  /// </summary>
  Subject = 16,
  /// <summary>
  /// Author field.
  /// </summary>
  Author = 17,
  /// <summary>
  /// Keywords field.
  /// </summary>
  KeyWord = 18,
  /// <summary>
  /// Comments field.
  /// </summary>
  Comments = 19,
  /// <summary>
  /// LastSavedBy field.
  /// </summary>
  LastSavedBy = 20,
  /// <summary>
  /// CreateDate field.
  /// </summary>
  CreateDate = 21,
  /// <summary>
  /// SaveDate field.
  /// </summary>
  SaveDate = 22,
  /// <summary>
  /// PrintDate field.
  /// </summary>
  PrintDate = 23,
  /// <summary>
  /// RevNum field.
  /// </summary>
  RevisionNum = 24,
  /// <summary>
  /// EditTime field.
  /// </summary>
  EditTime = 25,
  /// <summary>
  /// NumPages field.
  /// </summary>
  NumPages = 26,
  /// <summary>
  /// NumWords field.
  /// </summary>
  NumWords = 27,
  /// <summary>
  /// NumChars field.
  /// </summary>
  NumChars = 28,
  /// <summary>
  /// FileName field.
  /// </summary>
  FileName = 29,
  /// <summary>
  /// Template field.
  /// </summary>
  Template = 30,
  /// <summary>
  /// Date field.
  /// </summary>
  Date = 31,
  /// <summary>
  /// Time field.
  /// </summary>
  Time = 32,
  /// <summary>
  /// Page field.
  /// </summary>
  Page = 33,
  /// <summary>
  /// = (Formula) field.
  /// </summary>
  Expression = 34,
  /// <summary>
  /// Quote field.
  /// </summary>
  Quote = 35,
  /// <summary>
  /// Include field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  Include = 36,
  /// <summary>
  /// PageRef field.
  /// </summary>
  PageRef = 37,
  /// <summary>
  /// Ask field.
  /// </summary>
  Ask = 38,
  /// <summary>
  /// Fill-In field.
  /// </summary>
  FillIn = 39,
  /// <summary>
  /// Data field.
  /// </summary>
  Data = 40,
  /// <summary>
  /// Next field.
  /// </summary>
  Next = 41,
  /// <summary>
  /// NextIf field.
  /// </summary>
  NextIf = 42,
  /// <summary>
  /// SkipIf field.
  /// </summary>
  SkipIf = 43,
  /// <summary>
  /// MergeRec field.
  /// </summary>
  MergeRec = 44,
  /// <summary>
  /// DDE field. No longer available through the Field dialog box, but supported for documents created in earlier
  /// versions of Microsoft Word.
  /// </summary>
  DDE = 45,
  /// <summary>
  /// DDEAuto field. No longer available through the Field dialog box, but supported for documents created in
  /// earlier versions of Microsoft Word.
  /// </summary>
  DDEAuto = 46,
  /// <summary>
  /// Glossary field. No longer supported in Microsoft Word.
  /// </summary>
  Glossary = 47,
  /// <summary>
  /// Print field.
  /// </summary>
  Print = 48,
  /// <summary>
  /// EQ (Equation) field.
  /// </summary>
  Formula = 49,
  /// <summary>
  /// GoToButton field.
  /// </summary>
  GoToButton = 50,
  /// <summary>
  /// MacroButton field.
  /// </summary>
  MacroButton = 51,
  /// <summary>
  /// AutoNumOut field.
  /// </summary>
  AutoNumOutline = 52,
  /// <summary>
  /// AutoNumLgl field.
  /// </summary>
  AutoNumLegal = 53,
  /// <summary>
  /// AutoNum field.
  /// </summary>
  AutoNum = 54,
  /// <summary>
  /// Import field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  Import = 55,
  /// <summary>
  /// Link field.
  /// </summary>
  Link = 56,
  /// <summary>
  /// Symbol field.
  /// </summary>
  Symbol = 57,
  /// <summary>
  /// Embedded field.
  /// </summary>
  Embed = 58,
  /// <summary>
  /// MergeField field.
  /// </summary>
  MergeField = 59,
  /// <summary>
  /// UserName field.
  /// </summary>
  UserName = 60,
  /// <summary>
  /// UserInitials field.
  /// </summary>
  UserInitials = 61,
  /// <summary>
  /// UserAddress field.
  /// </summary>
  UserAddress = 62,
  /// <summary>
  /// BarCode field.
  /// </summary>
  BarCode = 63,
  /// <summary>
  /// DocVariable field.
  /// </summary>
  DocVariable = 64,
  /// <summary>
  /// Section field.
  /// </summary>
  Section = 65,
  /// <summary>
  /// SectionPages field.
  /// </summary>
  SectionPages = 66,
  /// <summary>
  /// IncludePicture field.
  /// </summary>
  IncludePicture = 67,
  /// <summary>
  /// IncludeText field.
  /// </summary>
  IncludeText = 68,
  /// <summary>
  /// FileSize field.
  /// </summary>
  FileSize = 69,
  /// <summary>
  /// FormText field. Inserted with the Text Form Field button on the Forms toolbar rather than through the Fields
  /// dialog box or through code.
  /// </summary>
  FormTextInput = 70,
  /// <summary>
  /// FormCheckBox field. Inserted with the Check Box Form Field button on the Forms toolbar rather than through the
  /// Field dialog box or through code.
  /// </summary>
  FormCheckBox = 71,
  /// <summary>
  /// NoteRef field.
  /// </summary>
  NoteRef = 72,
  /// <summary>
  /// TOA (Table of Authorities) field.
  /// </summary>
  TOA = 73,
  /// <summary>
  /// TOA (Table of Authorities Entry) field.
  /// </summary>
  TOAEntry = 74,
  /// <summary>
  /// MergeSeq field.
  /// </summary>
  MergeSeq = 75,
  /// <summary>
  /// Private field.
  /// </summary>
  Private = 77,
  /// <summary>
  /// Database field.
  /// </summary>
  Database = 78,
  /// <summary>
  /// AutoText field.
  /// </summary>
  AutoText = 79,
  /// <summary>
  /// Compare field.
  /// </summary>
  Compare = 80,
  /// <summary>
  /// Add-in field. Not available through the Field dialog box. Used to store data that is hidden from the user
  /// interface.
  /// </summary>
  Addin = 81,
  /// <summary>
  /// Subscriber field.
  /// </summary>
  Subscriber = 82,
  /// <summary>
  /// FormDropDown field. Inserted with the Drop-Down Form Field button on the Forms toolbar rather than through the
  /// Field dialog box or through code.
  /// </summary>
  FormDropDown = 83,
  /// <summary>
  /// Advance field.
  /// </summary>
  Advance = 84,
  /// <summary>
  /// DocProperty field.
  /// </summary>
  DocProperty = 85,
  /// <summary>
  /// OCX field. Cannot be added through the Field dialog box, but can be added through code by using the
  /// AddOLEControl method of the FormFields collection.
  /// </summary>
  OCX = 87,
  /// <summary>
  /// Hyperlink field.
  /// </summary>
  Hyperlink = 88,
  /// <summary>
  /// AutoTextList field.
  /// </summary>
  AutoTextList = 89,
  /// <summary>
  /// ListNum field.
  /// </summary>
  ListNum = 90,
  /// <summary>
  /// HTMLActiveX field. Not currently supported.
  /// </summary>
  HTMLActiveX = 91,
  /// <summary>
  /// BidiOutline field.
  /// </summary>
  BidiOutline = 92,
  /// <summary>
  /// AddressBlock field.
  /// </summary>
  AddressBlock = 93,
  /// <summary>
  /// GreetingLine field.
  /// </summary>
  GreetingLine = 94,
  /// <summary>
  /// Shape field. Automatically created for any drawn picture.
  /// </summary>
  Shape = 95,
  /// <summary>
  /// Citation field.
  /// </summary>
  Citation = 96,
  /// <summary>
  /// Bibliography field.
  /// </summary>
  Bibliography = 97,
  /// <summary>
  /// MergeBarcode field.
  /// </summary>
  MergeBarcode = 98,
  /// <summary>
  /// DisplayBarcode field.
  /// </summary>
  DisplayBarcode = 99,
  /// <summary>
  /// Empty field. Acts as a placeholder for field content that has not yet been added. A field added by pressing
  /// Ctrl+F9 in the user interface is an Empty field.
  /// </summary>
  Empty = -1
}
