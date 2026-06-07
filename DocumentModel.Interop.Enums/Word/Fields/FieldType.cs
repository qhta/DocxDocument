namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a Microsoft Word field.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdFieldType")]
public enum FieldType
{
  /// <summary>
  /// Ref field.
  /// </summary>
  [InteropEnumValue("wdFieldRef")]
  Ref = 3,
  /// <summary>
  /// XE (Index Entry) field.
  /// </summary>
  [InteropEnumValue("wdFieldIndexEntry")]
  IndexEntry = 4,
  /// <summary>
  /// FootnoteRef field. Not available through the Field dialog box. Inserted programmatically or interactively.
  /// </summary>
  [InteropEnumValue("wdFieldFootnoteRef")]
  FootnoteRef = 5,
  /// <summary>
  /// Set field.
  /// </summary>
  [InteropEnumValue("wdFieldSet")]
  Set = 6,
  /// <summary>
  /// If field.
  /// </summary>
  [InteropEnumValue("wdFieldIf")]
  If = 7,
  /// <summary>
  /// Index field.
  /// </summary>
  [InteropEnumValue("wdFieldIndex")]
  Index = 8,
  /// <summary>
  /// TOC (Table of Contents Entry) field.
  /// </summary>
  [InteropEnumValue("wdFieldTOCEntry")]
  TOCEntry = 9,
  /// <summary>
  /// StyleRef field.
  /// </summary>
  [InteropEnumValue("wdFieldStyleRef")]
  StyleRef = 10,
  /// <summary>
  /// RD (Reference Document) field.
  /// </summary>
  [InteropEnumValue("wdFieldRefDoc")]
  RefDoc = 11,
  /// <summary>
  /// Seq (Sequence) field.
  /// </summary>
  [InteropEnumValue("wdFieldSequence")]
  Sequence = 12,
  /// <summary>
  /// TOC (Table of Contents) field.
  /// </summary>
  [InteropEnumValue("wdFieldTOC")]
  TOC = 13,
  /// <summary>
  /// Info field.
  /// </summary>
  [InteropEnumValue("wdFieldInfo")]
  Info = 14,
  /// <summary>
  /// Title field.
  /// </summary>
  [InteropEnumValue("wdFieldTitle")]
  Title = 15,
  /// <summary>
  /// Subject field.
  /// </summary>
  [InteropEnumValue("wdFieldSubject")]
  Subject = 16,
  /// <summary>
  /// Author field.
  /// </summary>
  [InteropEnumValue("wdFieldAuthor")]
  Author = 17,
  /// <summary>
  /// Keywords field.
  /// </summary>
  [InteropEnumValue("wdFieldKeyWord")]
  KeyWord = 18,
  /// <summary>
  /// Comments field.
  /// </summary>
  [InteropEnumValue("wdFieldComments")]
  Comments = 19,
  /// <summary>
  /// LastSavedBy field.
  /// </summary>
  [InteropEnumValue("wdFieldLastSavedBy")]
  LastSavedBy = 20,
  /// <summary>
  /// CreateDate field.
  /// </summary>
  [InteropEnumValue("wdFieldCreateDate")]
  CreateDate = 21,
  /// <summary>
  /// SaveDate field.
  /// </summary>
  [InteropEnumValue("wdFieldSaveDate")]
  SaveDate = 22,
  /// <summary>
  /// PrintDate field.
  /// </summary>
  [InteropEnumValue("wdFieldPrintDate")]
  PrintDate = 23,
  /// <summary>
  /// RevNum field.
  /// </summary>
  [InteropEnumValue("wdFieldRevisionNum")]
  RevisionNum = 24,
  /// <summary>
  /// EditTime field.
  /// </summary>
  [InteropEnumValue("wdFieldEditTime")]
  EditTime = 25,
  /// <summary>
  /// NumPages field.
  /// </summary>
  [InteropEnumValue("wdFieldNumPages")]
  NumPages = 26,
  /// <summary>
  /// NumWords field.
  /// </summary>
  [InteropEnumValue("wdFieldNumWords")]
  NumWords = 27,
  /// <summary>
  /// NumChars field.
  /// </summary>
  [InteropEnumValue("wdFieldNumChars")]
  NumChars = 28,
  /// <summary>
  /// FileName field.
  /// </summary>
  [InteropEnumValue("wdFieldFileName")]
  FileName = 29,
  /// <summary>
  /// Template field.
  /// </summary>
  [InteropEnumValue("wdFieldTemplate")]
  Template = 30,
  /// <summary>
  /// Date field.
  /// </summary>
  [InteropEnumValue("wdFieldDate")]
  Date = 31,
  /// <summary>
  /// Time field.
  /// </summary>
  [InteropEnumValue("wdFieldTime")]
  Time = 32,
  /// <summary>
  /// Page field.
  /// </summary>
  [InteropEnumValue("wdFieldPage")]
  Page = 33,
  /// <summary>
  /// = (Formula) field.
  /// </summary>
  [InteropEnumValue("wdFieldExpression")]
  Expression = 34,
  /// <summary>
  /// Quote field.
  /// </summary>
  [InteropEnumValue("wdFieldQuote")]
  Quote = 35,
  /// <summary>
  /// Include field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  [InteropEnumValue("wdFieldInclude")]
  Include = 36,
  /// <summary>
  /// PageRef field.
  /// </summary>
  [InteropEnumValue("wdFieldPageRef")]
  PageRef = 37,
  /// <summary>
  /// Ask field.
  /// </summary>
  [InteropEnumValue("wdFieldAsk")]
  Ask = 38,
  /// <summary>
  /// Fill-In field.
  /// </summary>
  [InteropEnumValue("wdFieldFillIn")]
  FillIn = 39,
  /// <summary>
  /// Data field.
  /// </summary>
  [InteropEnumValue("wdFieldData")]
  Data = 40,
  /// <summary>
  /// Next field.
  /// </summary>
  [InteropEnumValue("wdFieldNext")]
  Next = 41,
  /// <summary>
  /// NextIf field.
  /// </summary>
  [InteropEnumValue("wdFieldNextIf")]
  NextIf = 42,
  /// <summary>
  /// SkipIf field.
  /// </summary>
  [InteropEnumValue("wdFieldSkipIf")]
  SkipIf = 43,
  /// <summary>
  /// MergeRec field.
  /// </summary>
  [InteropEnumValue("wdFieldMergeRec")]
  MergeRec = 44,
  /// <summary>
  /// DDE field. No longer available through the Field dialog box, but supported for documents created in earlier
  /// versions of Microsoft Word.
  /// </summary>
  [InteropEnumValue("wdFieldDDE")]
  DDE = 45,
  /// <summary>
  /// DDEAuto field. No longer available through the Field dialog box, but supported for documents created in
  /// earlier versions of Microsoft Word.
  /// </summary>
  [InteropEnumValue("wdFieldDDEAuto")]
  DDEAuto = 46,
  /// <summary>
  /// Glossary field. No longer supported in Microsoft Word.
  /// </summary>
  [InteropEnumValue("wdFieldGlossary")]
  Glossary = 47,
  /// <summary>
  /// Print field.
  /// </summary>
  [InteropEnumValue("wdFieldPrint")]
  Print = 48,
  /// <summary>
  /// EQ (Equation) field.
  /// </summary>
  [InteropEnumValue("wdFieldFormula")]
  Formula = 49,
  /// <summary>
  /// GoToButton field.
  /// </summary>
  [InteropEnumValue("wdFieldGoToButton")]
  GoToButton = 50,
  /// <summary>
  /// MacroButton field.
  /// </summary>
  [InteropEnumValue("wdFieldMacroButton")]
  MacroButton = 51,
  /// <summary>
  /// AutoNumOut field.
  /// </summary>
  [InteropEnumValue("wdFieldAutoNumOutline")]
  AutoNumOutline = 52,
  /// <summary>
  /// AutoNumLgl field.
  /// </summary>
  [InteropEnumValue("wdFieldAutoNumLegal")]
  AutoNumLegal = 53,
  /// <summary>
  /// AutoNum field.
  /// </summary>
  [InteropEnumValue("wdFieldAutoNum")]
  AutoNum = 54,
  /// <summary>
  /// Import field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  [InteropEnumValue("wdFieldImport")]
  Import = 55,
  /// <summary>
  /// Link field.
  /// </summary>
  [InteropEnumValue("wdFieldLink")]
  Link = 56,
  /// <summary>
  /// Symbol field.
  /// </summary>
  [InteropEnumValue("wdFieldSymbol")]
  Symbol = 57,
  /// <summary>
  /// Embedded field.
  /// </summary>
  [InteropEnumValue("wdFieldEmbed")]
  Embed = 58,
  /// <summary>
  /// MergeField field.
  /// </summary>
  [InteropEnumValue("wdFieldMergeField")]
  MergeField = 59,
  /// <summary>
  /// UserName field.
  /// </summary>
  [InteropEnumValue("wdFieldUserName")]
  UserName = 60,
  /// <summary>
  /// UserInitials field.
  /// </summary>
  [InteropEnumValue("wdFieldUserInitials")]
  UserInitials = 61,
  /// <summary>
  /// UserAddress field.
  /// </summary>
  [InteropEnumValue("wdFieldUserAddress")]
  UserAddress = 62,
  /// <summary>
  /// BarCode field.
  /// </summary>
  [InteropEnumValue("wdFieldBarCode")]
  BarCode = 63,
  /// <summary>
  /// DocVariable field.
  /// </summary>
  [InteropEnumValue("wdFieldDocVariable")]
  DocVariable = 64,
  /// <summary>
  /// Section field.
  /// </summary>
  [InteropEnumValue("wdFieldSection")]
  Section = 65,
  /// <summary>
  /// SectionPages field.
  /// </summary>
  [InteropEnumValue("wdFieldSectionPages")]
  SectionPages = 66,
  /// <summary>
  /// IncludePicture field.
  /// </summary>
  [InteropEnumValue("wdFieldIncludePicture")]
  IncludePicture = 67,
  /// <summary>
  /// IncludeText field.
  /// </summary>
  [InteropEnumValue("wdFieldIncludeText")]
  IncludeText = 68,
  /// <summary>
  /// FileSize field.
  /// </summary>
  [InteropEnumValue("wdFieldFileSize")]
  FileSize = 69,
  /// <summary>
  /// FormText field. Inserted with the Text Form Field button on the Forms toolbar rather than through the Fields
  /// dialog box or through code.
  /// </summary>
  [InteropEnumValue("wdFieldFormTextInput")]
  FormTextInput = 70,
  /// <summary>
  /// FormCheckBox field. Inserted with the Check Box Form Field button on the Forms toolbar rather than through the
  /// Field dialog box or through code.
  /// </summary>
  [InteropEnumValue("wdFieldFormCheckBox")]
  FormCheckBox = 71,
  /// <summary>
  /// NoteRef field.
  /// </summary>
  [InteropEnumValue("wdFieldNoteRef")]
  NoteRef = 72,
  /// <summary>
  /// TOA (Table of Authorities) field.
  /// </summary>
  [InteropEnumValue("wdFieldTOA")]
  TOA = 73,
  /// <summary>
  /// TOA (Table of Authorities Entry) field.
  /// </summary>
  [InteropEnumValue("wdFieldTOAEntry")]
  TOAEntry = 74,
  /// <summary>
  /// MergeSeq field.
  /// </summary>
  [InteropEnumValue("wdFieldMergeSeq")]
  MergeSeq = 75,
  /// <summary>
  /// Private field.
  /// </summary>
  [InteropEnumValue("wdFieldPrivate")]
  Private = 77,
  /// <summary>
  /// Database field.
  /// </summary>
  [InteropEnumValue("wdFieldDatabase")]
  Database = 78,
  /// <summary>
  /// AutoText field.
  /// </summary>
  [InteropEnumValue("wdFieldAutoText")]
  AutoText = 79,
  /// <summary>
  /// Compare field.
  /// </summary>
  [InteropEnumValue("wdFieldCompare")]
  Compare = 80,
  /// <summary>
  /// Add-in field. Not available through the Field dialog box. Used to store data that is hidden from the user
  /// interface.
  /// </summary>
  [InteropEnumValue("wdFieldAddin")]
  Addin = 81,
  /// <summary>
  /// Subscriber field.
  /// </summary>
  [InteropEnumValue("wdFieldSubscriber")]
  Subscriber = 82,
  /// <summary>
  /// FormDropDown field. Inserted with the Drop-Down Form Field button on the Forms toolbar rather than through the
  /// Field dialog box or through code.
  /// </summary>
  [InteropEnumValue("wdFieldFormDropDown")]
  FormDropDown = 83,
  /// <summary>
  /// Advance field.
  /// </summary>
  [InteropEnumValue("wdFieldAdvance")]
  Advance = 84,
  /// <summary>
  /// DocProperty field.
  /// </summary>
  [InteropEnumValue("wdFieldDocProperty")]
  DocProperty = 85,
  /// <summary>
  /// OCX field. Cannot be added through the Field dialog box, but can be added through code by using the
  /// AddOLEControl method of the FormFields collection.
  /// </summary>
  [InteropEnumValue("wdFieldOCX")]
  OCX = 87,
  /// <summary>
  /// Hyperlink field.
  /// </summary>
  [InteropEnumValue("wdFieldHyperlink")]
  Hyperlink = 88,
  /// <summary>
  /// AutoTextList field.
  /// </summary>
  [InteropEnumValue("wdFieldAutoTextList")]
  AutoTextList = 89,
  /// <summary>
  /// ListNum field.
  /// </summary>
  [InteropEnumValue("wdFieldListNum")]
  ListNum = 90,
  /// <summary>
  /// HTMLActiveX field. Not currently supported.
  /// </summary>
  [InteropEnumValue("wdFieldHTMLActiveX")]
  HTMLActiveX = 91,
  /// <summary>
  /// BidiOutline field.
  /// </summary>
  [InteropEnumValue("wdFieldBidiOutline")]
  BidiOutline = 92,
  /// <summary>
  /// AddressBlock field.
  /// </summary>
  [InteropEnumValue("wdFieldAddressBlock")]
  AddressBlock = 93,
  /// <summary>
  /// GreetingLine field.
  /// </summary>
  [InteropEnumValue("wdFieldGreetingLine")]
  GreetingLine = 94,
  /// <summary>
  /// Shape field. Automatically created for any drawn picture.
  /// </summary>
  [InteropEnumValue("wdFieldShape")]
  Shape = 95,
  /// <summary>
  /// Citation field.
  /// </summary>
  [InteropEnumValue("wdFieldCitation")]
  Citation = 96,
  /// <summary>
  /// Bibliography field.
  /// </summary>
  [InteropEnumValue("wdFieldBibliography")]
  Bibliography = 97,
  /// <summary>
  /// MergeBarcode field.
  /// </summary>
  [InteropEnumValue("wdFieldMergeBarcode")]
  MergeBarcode = 98,
  /// <summary>
  /// DisplayBarcode field.
  /// </summary>
  [InteropEnumValue("wdFieldDisplayBarcode")]
  DisplayBarcode = 99,
  /// <summary>
  /// Empty field. Acts as a placeholder for field content that has not yet been added. A field added by pressing
  /// Ctrl+F9 in the user interface is an Empty field.
  /// </summary>
  [InteropEnumValue("wdFieldEmpty")]
  Empty = -1
}
