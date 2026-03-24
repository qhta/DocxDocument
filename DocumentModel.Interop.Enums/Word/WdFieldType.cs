namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a Microsoft Word field.
/// </summary>
public enum WdFieldType
{
  /// <summary>
  /// Ref field.
  /// </summary>
  Ref = unchecked((int)3),
  /// <summary>
  /// XE (Index Entry) field.
  /// </summary>
  IndexEntry = unchecked((int)4),
  /// <summary>
  /// FootnoteRef field. Not available through the Field dialog box. Inserted programmatically or interactively.
  /// </summary>
  FootnoteRef = unchecked((int)5),
  /// <summary>
  /// Set field.
  /// </summary>
  Set = unchecked((int)6),
  /// <summary>
  /// If field.
  /// </summary>
  If = unchecked((int)7),
  /// <summary>
  /// Index field.
  /// </summary>
  Index = unchecked((int)8),
  /// <summary>
  /// TOC (Table of Contents Entry) field.
  /// </summary>
  TOCEntry = unchecked((int)9),
  /// <summary>
  /// StyleRef field. [System.Runtime.InteropServices.Guid("AB7EDE63-D9C9-3D21-98B0-8DCC19D5BD63")] public enum
  /// WdFieldType ﾉ Expand table
  /// </summary>
  StyleRef = unchecked((int)10),
  /// <summary>
  /// RD (Reference Document) field.
  /// </summary>
  RefDoc = unchecked((int)11),
  /// <summary>
  /// Seq (Sequence) field.
  /// </summary>
  Sequence = unchecked((int)12),
  /// <summary>
  /// TOC (Table of Contents) field.
  /// </summary>
  TOC = unchecked((int)13),
  /// <summary>
  /// Info field.
  /// </summary>
  Info = unchecked((int)14),
  /// <summary>
  /// Title field.
  /// </summary>
  Title = unchecked((int)15),
  /// <summary>
  /// Subject field.
  /// </summary>
  Subject = unchecked((int)16),
  /// <summary>
  /// Author field.
  /// </summary>
  Author = unchecked((int)17),
  /// <summary>
  /// Keywords field.
  /// </summary>
  KeyWord = unchecked((int)18),
  /// <summary>
  /// Comments field.
  /// </summary>
  Comments = unchecked((int)19),
  /// <summary>
  /// LastSavedBy field.
  /// </summary>
  LastSavedBy = unchecked((int)20),
  /// <summary>
  /// CreateDate field.
  /// </summary>
  CreateDate = unchecked((int)21),
  /// <summary>
  /// SaveDate field.
  /// </summary>
  SaveDate = unchecked((int)22),
  /// <summary>
  /// PrintDate field.
  /// </summary>
  PrintDate = unchecked((int)23),
  /// <summary>
  /// RevNum field.
  /// </summary>
  RevisionNum = unchecked((int)24),
  /// <summary>
  /// EditTime field.
  /// </summary>
  EditTime = unchecked((int)25),
  /// <summary>
  /// NumPages field.
  /// </summary>
  NumPages = unchecked((int)26),
  /// <summary>
  /// NumWords field.
  /// </summary>
  NumWords = unchecked((int)27),
  /// <summary>
  /// NumChars field.
  /// </summary>
  NumChars = unchecked((int)28),
  /// <summary>
  /// FileName field.
  /// </summary>
  FileName = unchecked((int)29),
  /// <summary>
  /// Template field.
  /// </summary>
  Template = unchecked((int)30),
  /// <summary>
  /// Date field.
  /// </summary>
  Date = unchecked((int)31),
  /// <summary>
  /// Time field.
  /// </summary>
  Time = unchecked((int)32),
  /// <summary>
  /// Page field.
  /// </summary>
  Page = unchecked((int)33),
  /// <summary>
  /// = (Formula) field.
  /// </summary>
  Expression = unchecked((int)34),
  /// <summary>
  /// Quote field.
  /// </summary>
  Quote = unchecked((int)35),
  /// <summary>
  /// Include field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  Include = unchecked((int)36),
  /// <summary>
  /// PageRef field.
  /// </summary>
  PageRef = unchecked((int)37),
  /// <summary>
  /// Ask field.
  /// </summary>
  Ask = unchecked((int)38),
  /// <summary>
  /// Fill-In field.
  /// </summary>
  FillIn = unchecked((int)39),
  /// <summary>
  /// Data field.
  /// </summary>
  Data = unchecked((int)40),
  /// <summary>
  /// Next field.
  /// </summary>
  Next = unchecked((int)41),
  /// <summary>
  /// NextIf field.
  /// </summary>
  NextIf = unchecked((int)42),
  /// <summary>
  /// SkipIf field.
  /// </summary>
  SkipIf = unchecked((int)43),
  /// <summary>
  /// MergeRec field.
  /// </summary>
  MergeRec = unchecked((int)44),
  /// <summary>
  /// DDE field. No longer available through the Field dialog box, but supported for documents created in earlier
  /// versions of Microsoft Word.
  /// </summary>
  DDE = unchecked((int)45),
  /// <summary>
  /// DDEAuto field. No longer available through the Field dialog box, but supported for documents created in
  /// earlier versions of Microsoft Word.
  /// </summary>
  DDEAuto = unchecked((int)46),
  /// <summary>
  /// Glossary field. No longer supported in Microsoft Word.
  /// </summary>
  Glossary = unchecked((int)47),
  /// <summary>
  /// Print field.
  /// </summary>
  Print = unchecked((int)48),
  /// <summary>
  /// EQ (Equation) field.
  /// </summary>
  Formula = unchecked((int)49),
  /// <summary>
  /// GoToButton field. wdFieldMacroButton51 MacroButton field. wdFieldAutoNumOutline52 AutoNumOut field.
  /// wdFieldAutoNumLegal53 AutoNumLgl field.
  /// </summary>
  GoToButton = unchecked((int)50),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  MacroButton = unchecked((int)51),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AutoNumOutline = unchecked((int)52),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AutoNumLegal = unchecked((int)53),
  /// <summary>
  /// AutoNum field.
  /// </summary>
  AutoNum = unchecked((int)54),
  /// <summary>
  /// Import field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  Import = unchecked((int)55),
  /// <summary>
  /// Link field.
  /// </summary>
  Link = unchecked((int)56),
  /// <summary>
  /// Symbol field.
  /// </summary>
  Symbol = unchecked((int)57),
  /// <summary>
  /// Embedded field.
  /// </summary>
  Embed = unchecked((int)58),
  /// <summary>
  /// MergeField field.
  /// </summary>
  MergeField = unchecked((int)59),
  /// <summary>
  /// UserName field.
  /// </summary>
  UserName = unchecked((int)60),
  /// <summary>
  /// UserInitials field.
  /// </summary>
  UserInitials = unchecked((int)61),
  /// <summary>
  /// UserAddress field.
  /// </summary>
  UserAddress = unchecked((int)62),
  /// <summary>
  /// BarCode field.
  /// </summary>
  BarCode = unchecked((int)63),
  /// <summary>
  /// DocVariable field.
  /// </summary>
  DocVariable = unchecked((int)64),
  /// <summary>
  /// Section field.
  /// </summary>
  Section = unchecked((int)65),
  /// <summary>
  /// SectionPages field. wdFieldIncludePicture67 IncludePicture field.
  /// </summary>
  SectionPages = unchecked((int)66),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  IncludePicture = unchecked((int)67),
  /// <summary>
  /// IncludeText field.
  /// </summary>
  IncludeText = unchecked((int)68),
  /// <summary>
  /// FileSize field.
  /// </summary>
  FileSize = unchecked((int)69),
  /// <summary>
  /// FormText field. Inserted with the Text Form Field button on the Forms toolbar rather than through the Fields
  /// dialog box or through code. wdFieldFormCheckBox71 FormCheckBox field. Inserted with the Check Box Form Field
  /// button on the Forms toolbar rather than through the Field dialog box or through code.
  /// </summary>
  FormTextInput = unchecked((int)70),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  FormCheckBox = unchecked((int)71),
  /// <summary>
  /// NoteRef field.
  /// </summary>
  NoteRef = unchecked((int)72),
  /// <summary>
  /// TOA (Table of Authorities) field.
  /// </summary>
  TOA = unchecked((int)73),
  /// <summary>
  /// TOA (Table of Authorities Entry) field.
  /// </summary>
  TOAEntry = unchecked((int)74),
  /// <summary>
  /// MergeSeq field.
  /// </summary>
  MergeSeq = unchecked((int)75),
  /// <summary>
  /// Private field.
  /// </summary>
  Private = unchecked((int)77),
  /// <summary>
  /// Database field.
  /// </summary>
  Database = unchecked((int)78),
  /// <summary>
  /// AutoText field.
  /// </summary>
  AutoText = unchecked((int)79),
  /// <summary>
  /// Compare field.
  /// </summary>
  Compare = unchecked((int)80),
  /// <summary>
  /// Add-in field. Not available through the Field dialog box. Used to store data that is hidden from the user
  /// interface.
  /// </summary>
  Addin = unchecked((int)81),
  /// <summary>
  /// Subscriber field. wdFieldFormDropDown83 FormDropDown field. Inserted with the Drop-Down Form Field button on
  /// the Forms toolbar rather than through the Field dialog box or through code.
  /// </summary>
  Subscriber = unchecked((int)82),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  FormDropDown = unchecked((int)83),
  /// <summary>
  /// Advance field.
  /// </summary>
  Advance = unchecked((int)84),
  /// <summary>
  /// DocProperty field.
  /// </summary>
  DocProperty = unchecked((int)85),
  /// <summary>
  /// OCX field. Cannot be added through the Field dialog box, but can be added through code by using the
  /// AddOLEControl method of the FormFields collection.
  /// </summary>
  OCX = unchecked((int)87),
  /// <summary>
  /// Hyperlink field.
  /// </summary>
  Hyperlink = unchecked((int)88),
  /// <summary>
  /// AutoTextList field.
  /// </summary>
  AutoTextList = unchecked((int)89),
  /// <summary>
  /// ListNum field.
  /// </summary>
  ListNum = unchecked((int)90),
  /// <summary>
  /// HTMLActiveX field. Not currently supported.
  /// </summary>
  HTMLActiveX = unchecked((int)91),
  /// <summary>
  /// BidiOutline field. wdFieldAddressBlock93 AddressBlock field. wdFieldGreetingLine94 GreetingLine field.
  /// </summary>
  BidiOutline = unchecked((int)92),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  AddressBlock = unchecked((int)93),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  GreetingLine = unchecked((int)94),
  /// <summary>
  /// Shape field. Automatically created for any drawn picture.
  /// </summary>
  Shape = unchecked((int)95),
  /// <summary>
  /// Citation field. wdFieldBibliography97 Bibliography field. wdFieldMergeBarcode98 MergeBarcode field.
  /// wdFieldDisplayBarcode99 DisplayBarcode field.
  /// </summary>
  Citation = unchecked((int)96),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Bibliography = unchecked((int)97),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  MergeBarcode = unchecked((int)98),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  DisplayBarcode = unchecked((int)99),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  Empty = unchecked((int)-1)
}
