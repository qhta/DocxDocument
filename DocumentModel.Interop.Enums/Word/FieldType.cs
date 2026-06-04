namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a Microsoft Word field.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdFieldType")]
public enum FieldType
{
  /// <summary>
  /// Ref field.
  /// </summary>
  [WordInteropEnumValue("wdFieldRef")]
  Ref = 3,
  /// <summary>
  /// XE (Index Entry) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldIndexEntry")]
  IndexEntry = 4,
  /// <summary>
  /// FootnoteRef field. Not available through the Field dialog box. Inserted programmatically or interactively.
  /// </summary>
  [WordInteropEnumValue("wdFieldFootnoteRef")]
  FootnoteRef = 5,
  /// <summary>
  /// Set field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSet")]
  Set = 6,
  /// <summary>
  /// If field.
  /// </summary>
  [WordInteropEnumValue("wdFieldIf")]
  If = 7,
  /// <summary>
  /// Index field.
  /// </summary>
  [WordInteropEnumValue("wdFieldIndex")]
  Index = 8,
  /// <summary>
  /// TOC (Table of Contents Entry) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldTOCEntry")]
  TOCEntry = 9,
  /// <summary>
  /// StyleRef field.
  /// </summary>
  [WordInteropEnumValue("wdFieldStyleRef")]
  StyleRef = 10,
  /// <summary>
  /// RD (Reference Document) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldRefDoc")]
  RefDoc = 11,
  /// <summary>
  /// Seq (Sequence) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSequence")]
  Sequence = 12,
  /// <summary>
  /// TOC (Table of Contents) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldTOC")]
  TOC = 13,
  /// <summary>
  /// Info field.
  /// </summary>
  [WordInteropEnumValue("wdFieldInfo")]
  Info = 14,
  /// <summary>
  /// Title field.
  /// </summary>
  [WordInteropEnumValue("wdFieldTitle")]
  Title = 15,
  /// <summary>
  /// Subject field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSubject")]
  Subject = 16,
  /// <summary>
  /// Author field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAuthor")]
  Author = 17,
  /// <summary>
  /// Keywords field.
  /// </summary>
  [WordInteropEnumValue("wdFieldKeyWord")]
  KeyWord = 18,
  /// <summary>
  /// Comments field.
  /// </summary>
  [WordInteropEnumValue("wdFieldComments")]
  Comments = 19,
  /// <summary>
  /// LastSavedBy field.
  /// </summary>
  [WordInteropEnumValue("wdFieldLastSavedBy")]
  LastSavedBy = 20,
  /// <summary>
  /// CreateDate field.
  /// </summary>
  [WordInteropEnumValue("wdFieldCreateDate")]
  CreateDate = 21,
  /// <summary>
  /// SaveDate field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSaveDate")]
  SaveDate = 22,
  /// <summary>
  /// PrintDate field.
  /// </summary>
  [WordInteropEnumValue("wdFieldPrintDate")]
  PrintDate = 23,
  /// <summary>
  /// RevNum field.
  /// </summary>
  [WordInteropEnumValue("wdFieldRevisionNum")]
  RevisionNum = 24,
  /// <summary>
  /// EditTime field.
  /// </summary>
  [WordInteropEnumValue("wdFieldEditTime")]
  EditTime = 25,
  /// <summary>
  /// NumPages field.
  /// </summary>
  [WordInteropEnumValue("wdFieldNumPages")]
  NumPages = 26,
  /// <summary>
  /// NumWords field.
  /// </summary>
  [WordInteropEnumValue("wdFieldNumWords")]
  NumWords = 27,
  /// <summary>
  /// NumChars field.
  /// </summary>
  [WordInteropEnumValue("wdFieldNumChars")]
  NumChars = 28,
  /// <summary>
  /// FileName field.
  /// </summary>
  [WordInteropEnumValue("wdFieldFileName")]
  FileName = 29,
  /// <summary>
  /// Template field.
  /// </summary>
  [WordInteropEnumValue("wdFieldTemplate")]
  Template = 30,
  /// <summary>
  /// Date field.
  /// </summary>
  [WordInteropEnumValue("wdFieldDate")]
  Date = 31,
  /// <summary>
  /// Time field.
  /// </summary>
  [WordInteropEnumValue("wdFieldTime")]
  Time = 32,
  /// <summary>
  /// Page field.
  /// </summary>
  [WordInteropEnumValue("wdFieldPage")]
  Page = 33,
  /// <summary>
  /// = (Formula) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldExpression")]
  Expression = 34,
  /// <summary>
  /// Quote field.
  /// </summary>
  [WordInteropEnumValue("wdFieldQuote")]
  Quote = 35,
  /// <summary>
  /// Include field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  [WordInteropEnumValue("wdFieldInclude")]
  Include = 36,
  /// <summary>
  /// PageRef field.
  /// </summary>
  [WordInteropEnumValue("wdFieldPageRef")]
  PageRef = 37,
  /// <summary>
  /// Ask field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAsk")]
  Ask = 38,
  /// <summary>
  /// Fill-In field.
  /// </summary>
  [WordInteropEnumValue("wdFieldFillIn")]
  FillIn = 39,
  /// <summary>
  /// Data field.
  /// </summary>
  [WordInteropEnumValue("wdFieldData")]
  Data = 40,
  /// <summary>
  /// Next field.
  /// </summary>
  [WordInteropEnumValue("wdFieldNext")]
  Next = 41,
  /// <summary>
  /// NextIf field.
  /// </summary>
  [WordInteropEnumValue("wdFieldNextIf")]
  NextIf = 42,
  /// <summary>
  /// SkipIf field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSkipIf")]
  SkipIf = 43,
  /// <summary>
  /// MergeRec field.
  /// </summary>
  [WordInteropEnumValue("wdFieldMergeRec")]
  MergeRec = 44,
  /// <summary>
  /// DDE field. No longer available through the Field dialog box, but supported for documents created in earlier
  /// versions of Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("wdFieldDDE")]
  DDE = 45,
  /// <summary>
  /// DDEAuto field. No longer available through the Field dialog box, but supported for documents created in
  /// earlier versions of Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("wdFieldDDEAuto")]
  DDEAuto = 46,
  /// <summary>
  /// Glossary field. No longer supported in Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("wdFieldGlossary")]
  Glossary = 47,
  /// <summary>
  /// Print field.
  /// </summary>
  [WordInteropEnumValue("wdFieldPrint")]
  Print = 48,
  /// <summary>
  /// EQ (Equation) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldFormula")]
  Formula = 49,
  /// <summary>
  /// GoToButton field.
  /// </summary>
  [WordInteropEnumValue("wdFieldGoToButton")]
  GoToButton = 50,
  /// <summary>
  /// MacroButton field.
  /// </summary>
  [WordInteropEnumValue("wdFieldMacroButton")]
  MacroButton = 51,
  /// <summary>
  /// AutoNumOut field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAutoNumOutline")]
  AutoNumOutline = 52,
  /// <summary>
  /// AutoNumLgl field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAutoNumLegal")]
  AutoNumLegal = 53,
  /// <summary>
  /// AutoNum field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAutoNum")]
  AutoNum = 54,
  /// <summary>
  /// Import field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  [WordInteropEnumValue("wdFieldImport")]
  Import = 55,
  /// <summary>
  /// Link field.
  /// </summary>
  [WordInteropEnumValue("wdFieldLink")]
  Link = 56,
  /// <summary>
  /// Symbol field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSymbol")]
  Symbol = 57,
  /// <summary>
  /// Embedded field.
  /// </summary>
  [WordInteropEnumValue("wdFieldEmbed")]
  Embed = 58,
  /// <summary>
  /// MergeField field.
  /// </summary>
  [WordInteropEnumValue("wdFieldMergeField")]
  MergeField = 59,
  /// <summary>
  /// UserName field.
  /// </summary>
  [WordInteropEnumValue("wdFieldUserName")]
  UserName = 60,
  /// <summary>
  /// UserInitials field.
  /// </summary>
  [WordInteropEnumValue("wdFieldUserInitials")]
  UserInitials = 61,
  /// <summary>
  /// UserAddress field.
  /// </summary>
  [WordInteropEnumValue("wdFieldUserAddress")]
  UserAddress = 62,
  /// <summary>
  /// BarCode field.
  /// </summary>
  [WordInteropEnumValue("wdFieldBarCode")]
  BarCode = 63,
  /// <summary>
  /// DocVariable field.
  /// </summary>
  [WordInteropEnumValue("wdFieldDocVariable")]
  DocVariable = 64,
  /// <summary>
  /// Section field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSection")]
  Section = 65,
  /// <summary>
  /// SectionPages field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSectionPages")]
  SectionPages = 66,
  /// <summary>
  /// IncludePicture field.
  /// </summary>
  [WordInteropEnumValue("wdFieldIncludePicture")]
  IncludePicture = 67,
  /// <summary>
  /// IncludeText field.
  /// </summary>
  [WordInteropEnumValue("wdFieldIncludeText")]
  IncludeText = 68,
  /// <summary>
  /// FileSize field.
  /// </summary>
  [WordInteropEnumValue("wdFieldFileSize")]
  FileSize = 69,
  /// <summary>
  /// FormText field. Inserted with the Text Form Field button on the Forms toolbar rather than through the Fields
  /// dialog box or through code.
  /// </summary>
  [WordInteropEnumValue("wdFieldFormTextInput")]
  FormTextInput = 70,
  /// <summary>
  /// FormCheckBox field. Inserted with the Check Box Form Field button on the Forms toolbar rather than through the
  /// Field dialog box or through code.
  /// </summary>
  [WordInteropEnumValue("wdFieldFormCheckBox")]
  FormCheckBox = 71,
  /// <summary>
  /// NoteRef field.
  /// </summary>
  [WordInteropEnumValue("wdFieldNoteRef")]
  NoteRef = 72,
  /// <summary>
  /// TOA (Table of Authorities) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldTOA")]
  TOA = 73,
  /// <summary>
  /// TOA (Table of Authorities Entry) field.
  /// </summary>
  [WordInteropEnumValue("wdFieldTOAEntry")]
  TOAEntry = 74,
  /// <summary>
  /// MergeSeq field.
  /// </summary>
  [WordInteropEnumValue("wdFieldMergeSeq")]
  MergeSeq = 75,
  /// <summary>
  /// Private field.
  /// </summary>
  [WordInteropEnumValue("wdFieldPrivate")]
  Private = 77,
  /// <summary>
  /// Database field.
  /// </summary>
  [WordInteropEnumValue("wdFieldDatabase")]
  Database = 78,
  /// <summary>
  /// AutoText field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAutoText")]
  AutoText = 79,
  /// <summary>
  /// Compare field.
  /// </summary>
  [WordInteropEnumValue("wdFieldCompare")]
  Compare = 80,
  /// <summary>
  /// Add-in field. Not available through the Field dialog box. Used to store data that is hidden from the user
  /// interface.
  /// </summary>
  [WordInteropEnumValue("wdFieldAddin")]
  Addin = 81,
  /// <summary>
  /// Subscriber field.
  /// </summary>
  [WordInteropEnumValue("wdFieldSubscriber")]
  Subscriber = 82,
  /// <summary>
  /// FormDropDown field. Inserted with the Drop-Down Form Field button on the Forms toolbar rather than through the
  /// Field dialog box or through code.
  /// </summary>
  [WordInteropEnumValue("wdFieldFormDropDown")]
  FormDropDown = 83,
  /// <summary>
  /// Advance field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAdvance")]
  Advance = 84,
  /// <summary>
  /// DocProperty field.
  /// </summary>
  [WordInteropEnumValue("wdFieldDocProperty")]
  DocProperty = 85,
  /// <summary>
  /// OCX field. Cannot be added through the Field dialog box, but can be added through code by using the
  /// AddOLEControl method of the FormFields collection.
  /// </summary>
  [WordInteropEnumValue("wdFieldOCX")]
  OCX = 87,
  /// <summary>
  /// Hyperlink field.
  /// </summary>
  [WordInteropEnumValue("wdFieldHyperlink")]
  Hyperlink = 88,
  /// <summary>
  /// AutoTextList field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAutoTextList")]
  AutoTextList = 89,
  /// <summary>
  /// ListNum field.
  /// </summary>
  [WordInteropEnumValue("wdFieldListNum")]
  ListNum = 90,
  /// <summary>
  /// HTMLActiveX field. Not currently supported.
  /// </summary>
  [WordInteropEnumValue("wdFieldHTMLActiveX")]
  HTMLActiveX = 91,
  /// <summary>
  /// BidiOutline field.
  /// </summary>
  [WordInteropEnumValue("wdFieldBidiOutline")]
  BidiOutline = 92,
  /// <summary>
  /// AddressBlock field.
  /// </summary>
  [WordInteropEnumValue("wdFieldAddressBlock")]
  AddressBlock = 93,
  /// <summary>
  /// GreetingLine field.
  /// </summary>
  [WordInteropEnumValue("wdFieldGreetingLine")]
  GreetingLine = 94,
  /// <summary>
  /// Shape field. Automatically created for any drawn picture.
  /// </summary>
  [WordInteropEnumValue("wdFieldShape")]
  Shape = 95,
  /// <summary>
  /// Citation field.
  /// </summary>
  [WordInteropEnumValue("wdFieldCitation")]
  Citation = 96,
  /// <summary>
  /// Bibliography field.
  /// </summary>
  [WordInteropEnumValue("wdFieldBibliography")]
  Bibliography = 97,
  /// <summary>
  /// MergeBarcode field.
  /// </summary>
  [WordInteropEnumValue("wdFieldMergeBarcode")]
  MergeBarcode = 98,
  /// <summary>
  /// DisplayBarcode field.
  /// </summary>
  [WordInteropEnumValue("wdFieldDisplayBarcode")]
  DisplayBarcode = 99,
  /// <summary>
  /// Empty field. Acts as a placeholder for field content that has not yet been added. A field added by pressing
  /// Ctrl+F9 in the user interface is an Empty field.
  /// </summary>
  [WordInteropEnumValue("wdFieldEmpty")]
  Empty = -1
}
