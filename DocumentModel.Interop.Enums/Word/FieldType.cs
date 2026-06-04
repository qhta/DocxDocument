namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a Microsoft Word field.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfieldtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFieldType))]
public enum FieldType
{
  /// <summary>
  /// Ref field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldRef))]
  Ref = 3,
  /// <summary>
  /// XE (Index Entry) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldIndexEntry))]
  IndexEntry = 4,
  /// <summary>
  /// FootnoteRef field. Not available through the Field dialog box. Inserted programmatically or interactively.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldFootnoteRef))]
  FootnoteRef = 5,
  /// <summary>
  /// Set field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSet))]
  Set = 6,
  /// <summary>
  /// If field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldIf))]
  If = 7,
  /// <summary>
  /// Index field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldIndex))]
  Index = 8,
  /// <summary>
  /// TOC (Table of Contents Entry) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldTOCEntry))]
  TOCEntry = 9,
  /// <summary>
  /// StyleRef field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldStyleRef))]
  StyleRef = 10,
  /// <summary>
  /// RD (Reference Document) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldRefDoc))]
  RefDoc = 11,
  /// <summary>
  /// Seq (Sequence) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSequence))]
  Sequence = 12,
  /// <summary>
  /// TOC (Table of Contents) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldTOC))]
  TOC = 13,
  /// <summary>
  /// Info field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldInfo))]
  Info = 14,
  /// <summary>
  /// Title field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldTitle))]
  Title = 15,
  /// <summary>
  /// Subject field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSubject))]
  Subject = 16,
  /// <summary>
  /// Author field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAuthor))]
  Author = 17,
  /// <summary>
  /// Keywords field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldKeyWord))]
  KeyWord = 18,
  /// <summary>
  /// Comments field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldComments))]
  Comments = 19,
  /// <summary>
  /// LastSavedBy field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldLastSavedBy))]
  LastSavedBy = 20,
  /// <summary>
  /// CreateDate field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldCreateDate))]
  CreateDate = 21,
  /// <summary>
  /// SaveDate field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSaveDate))]
  SaveDate = 22,
  /// <summary>
  /// PrintDate field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldPrintDate))]
  PrintDate = 23,
  /// <summary>
  /// RevNum field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldRevisionNum))]
  RevisionNum = 24,
  /// <summary>
  /// EditTime field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldEditTime))]
  EditTime = 25,
  /// <summary>
  /// NumPages field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldNumPages))]
  NumPages = 26,
  /// <summary>
  /// NumWords field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldNumWords))]
  NumWords = 27,
  /// <summary>
  /// NumChars field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldNumChars))]
  NumChars = 28,
  /// <summary>
  /// FileName field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldFileName))]
  FileName = 29,
  /// <summary>
  /// Template field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldTemplate))]
  Template = 30,
  /// <summary>
  /// Date field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldDate))]
  Date = 31,
  /// <summary>
  /// Time field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldTime))]
  Time = 32,
  /// <summary>
  /// Page field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage))]
  Page = 33,
  /// <summary>
  /// = (Formula) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldExpression))]
  Expression = 34,
  /// <summary>
  /// Quote field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldQuote))]
  Quote = 35,
  /// <summary>
  /// Include field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldInclude))]
  Include = 36,
  /// <summary>
  /// PageRef field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldPageRef))]
  PageRef = 37,
  /// <summary>
  /// Ask field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAsk))]
  Ask = 38,
  /// <summary>
  /// Fill-In field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldFillIn))]
  FillIn = 39,
  /// <summary>
  /// Data field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldData))]
  Data = 40,
  /// <summary>
  /// Next field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldNext))]
  Next = 41,
  /// <summary>
  /// NextIf field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldNextIf))]
  NextIf = 42,
  /// <summary>
  /// SkipIf field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSkipIf))]
  SkipIf = 43,
  /// <summary>
  /// MergeRec field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldMergeRec))]
  MergeRec = 44,
  /// <summary>
  /// DDE field. No longer available through the Field dialog box, but supported for documents created in earlier
  /// versions of Microsoft Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldDDE))]
  DDE = 45,
  /// <summary>
  /// DDEAuto field. No longer available through the Field dialog box, but supported for documents created in
  /// earlier versions of Microsoft Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldDDEAuto))]
  DDEAuto = 46,
  /// <summary>
  /// Glossary field. No longer supported in Microsoft Word.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldGlossary))]
  Glossary = 47,
  /// <summary>
  /// Print field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldPrint))]
  Print = 48,
  /// <summary>
  /// EQ (Equation) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldFormula))]
  Formula = 49,
  /// <summary>
  /// GoToButton field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldGoToButton))]
  GoToButton = 50,
  /// <summary>
  /// MacroButton field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldMacroButton))]
  MacroButton = 51,
  /// <summary>
  /// AutoNumOut field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAutoNumOutline))]
  AutoNumOutline = 52,
  /// <summary>
  /// AutoNumLgl field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAutoNumLegal))]
  AutoNumLegal = 53,
  /// <summary>
  /// AutoNum field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAutoNum))]
  AutoNum = 54,
  /// <summary>
  /// Import field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldImport))]
  Import = 55,
  /// <summary>
  /// Link field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldLink))]
  Link = 56,
  /// <summary>
  /// Symbol field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSymbol))]
  Symbol = 57,
  /// <summary>
  /// Embedded field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldEmbed))]
  Embed = 58,
  /// <summary>
  /// MergeField field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldMergeField))]
  MergeField = 59,
  /// <summary>
  /// UserName field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldUserName))]
  UserName = 60,
  /// <summary>
  /// UserInitials field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldUserInitials))]
  UserInitials = 61,
  /// <summary>
  /// UserAddress field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldUserAddress))]
  UserAddress = 62,
  /// <summary>
  /// BarCode field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldBarCode))]
  BarCode = 63,
  /// <summary>
  /// DocVariable field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldDocVariable))]
  DocVariable = 64,
  /// <summary>
  /// Section field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSection))]
  Section = 65,
  /// <summary>
  /// SectionPages field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSectionPages))]
  SectionPages = 66,
  /// <summary>
  /// IncludePicture field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldIncludePicture))]
  IncludePicture = 67,
  /// <summary>
  /// IncludeText field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldIncludeText))]
  IncludeText = 68,
  /// <summary>
  /// FileSize field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldFileSize))]
  FileSize = 69,
  /// <summary>
  /// FormText field. Inserted with the Text Form Field button on the Forms toolbar rather than through the Fields
  /// dialog box or through code.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldFormTextInput))]
  FormTextInput = 70,
  /// <summary>
  /// FormCheckBox field. Inserted with the Check Box Form Field button on the Forms toolbar rather than through the
  /// Field dialog box or through code.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldFormCheckBox))]
  FormCheckBox = 71,
  /// <summary>
  /// NoteRef field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldNoteRef))]
  NoteRef = 72,
  /// <summary>
  /// TOA (Table of Authorities) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldTOA))]
  TOA = 73,
  /// <summary>
  /// TOA (Table of Authorities Entry) field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldTOAEntry))]
  TOAEntry = 74,
  /// <summary>
  /// MergeSeq field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldMergeSeq))]
  MergeSeq = 75,
  /// <summary>
  /// Private field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldPrivate))]
  Private = 77,
  /// <summary>
  /// Database field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldDatabase))]
  Database = 78,
  /// <summary>
  /// AutoText field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAutoText))]
  AutoText = 79,
  /// <summary>
  /// Compare field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldCompare))]
  Compare = 80,
  /// <summary>
  /// Add-in field. Not available through the Field dialog box. Used to store data that is hidden from the user
  /// interface.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAddin))]
  Addin = 81,
  /// <summary>
  /// Subscriber field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldSubscriber))]
  Subscriber = 82,
  /// <summary>
  /// FormDropDown field. Inserted with the Drop-Down Form Field button on the Forms toolbar rather than through the
  /// Field dialog box or through code.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldFormDropDown))]
  FormDropDown = 83,
  /// <summary>
  /// Advance field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAdvance))]
  Advance = 84,
  /// <summary>
  /// DocProperty field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldDocProperty))]
  DocProperty = 85,
  /// <summary>
  /// OCX field. Cannot be added through the Field dialog box, but can be added through code by using the
  /// AddOLEControl method of the FormFields collection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldOCX))]
  OCX = 87,
  /// <summary>
  /// Hyperlink field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldHyperlink))]
  Hyperlink = 88,
  /// <summary>
  /// AutoTextList field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAutoTextList))]
  AutoTextList = 89,
  /// <summary>
  /// ListNum field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldListNum))]
  ListNum = 90,
  /// <summary>
  /// HTMLActiveX field. Not currently supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldHTMLActiveX))]
  HTMLActiveX = 91,
  /// <summary>
  /// BidiOutline field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldBidiOutline))]
  BidiOutline = 92,
  /// <summary>
  /// AddressBlock field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldAddressBlock))]
  AddressBlock = 93,
  /// <summary>
  /// GreetingLine field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldGreetingLine))]
  GreetingLine = 94,
  /// <summary>
  /// Shape field. Automatically created for any drawn picture.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldShape))]
  Shape = 95,
  /// <summary>
  /// Citation field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldCitation))]
  Citation = 96,
  /// <summary>
  /// Bibliography field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldBibliography))]
  Bibliography = 97,
  /// <summary>
  /// MergeBarcode field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldMergeBarcode))]
  MergeBarcode = 98,
  /// <summary>
  /// DisplayBarcode field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldDisplayBarcode))]
  DisplayBarcode = 99,
  /// <summary>
  /// Empty field. Acts as a placeholder for field content that has not yet been added. A field added by pressing
  /// Ctrl+F9 in the user interface is an Empty field.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFieldType.wdFieldEmpty))]
  Empty = -1
}
