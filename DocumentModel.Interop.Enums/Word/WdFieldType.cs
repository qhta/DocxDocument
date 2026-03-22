namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a Microsoft Word field.
/// </summary>
public enum WdFieldType
{
  /// <summary>
  /// Ref field.
  /// </summary>
  wdFieldRef = unchecked((int)3),
  /// <summary>
  /// XE (Index Entry) field.
  /// </summary>
  wdFieldIndexEntry = unchecked((int)4),
  /// <summary>
  /// FootnoteRef field. Not available through the Field dialog box. Inserted programmatically or interactively.
  /// </summary>
  wdFieldFootnoteRef = unchecked((int)5),
  /// <summary>
  /// Set field.
  /// </summary>
  wdFieldSet = unchecked((int)6),
  /// <summary>
  /// If field.
  /// </summary>
  wdFieldIf = unchecked((int)7),
  /// <summary>
  /// Index field.
  /// </summary>
  wdFieldIndex = unchecked((int)8),
  /// <summary>
  /// TOC (Table of Contents Entry) field.
  /// </summary>
  wdFieldTOCEntry = unchecked((int)9),
  /// <summary>
  /// StyleRef field. [System.Runtime.InteropServices.Guid("AB7EDE63-D9C9-3D21-98B0-8DCC19D5BD63")] public enum
  /// WdFieldType ﾉ Expand table
  /// </summary>
  wdFieldStyleRef = unchecked((int)10),
  /// <summary>
  /// RD (Reference Document) field.
  /// </summary>
  wdFieldRefDoc = unchecked((int)11),
  /// <summary>
  /// Seq (Sequence) field.
  /// </summary>
  wdFieldSequence = unchecked((int)12),
  /// <summary>
  /// TOC (Table of Contents) field.
  /// </summary>
  wdFieldTOC = unchecked((int)13),
  /// <summary>
  /// Info field.
  /// </summary>
  wdFieldInfo = unchecked((int)14),
  /// <summary>
  /// Title field.
  /// </summary>
  wdFieldTitle = unchecked((int)15),
  /// <summary>
  /// Subject field.
  /// </summary>
  wdFieldSubject = unchecked((int)16),
  /// <summary>
  /// Author field.
  /// </summary>
  wdFieldAuthor = unchecked((int)17),
  /// <summary>
  /// Keywords field.
  /// </summary>
  wdFieldKeyWord = unchecked((int)18),
  /// <summary>
  /// Comments field.
  /// </summary>
  wdFieldComments = unchecked((int)19),
  /// <summary>
  /// LastSavedBy field.
  /// </summary>
  wdFieldLastSavedBy = unchecked((int)20),
  /// <summary>
  /// CreateDate field.
  /// </summary>
  wdFieldCreateDate = unchecked((int)21),
  /// <summary>
  /// SaveDate field.
  /// </summary>
  wdFieldSaveDate = unchecked((int)22),
  /// <summary>
  /// PrintDate field.
  /// </summary>
  wdFieldPrintDate = unchecked((int)23),
  /// <summary>
  /// RevNum field.
  /// </summary>
  wdFieldRevisionNum = unchecked((int)24),
  /// <summary>
  /// EditTime field.
  /// </summary>
  wdFieldEditTime = unchecked((int)25),
  /// <summary>
  /// NumPages field.
  /// </summary>
  wdFieldNumPages = unchecked((int)26),
  /// <summary>
  /// NumWords field.
  /// </summary>
  wdFieldNumWords = unchecked((int)27),
  /// <summary>
  /// NumChars field.
  /// </summary>
  wdFieldNumChars = unchecked((int)28),
  /// <summary>
  /// FileName field.
  /// </summary>
  wdFieldFileName = unchecked((int)29),
  /// <summary>
  /// Template field.
  /// </summary>
  wdFieldTemplate = unchecked((int)30),
  /// <summary>
  /// Date field.
  /// </summary>
  wdFieldDate = unchecked((int)31),
  /// <summary>
  /// Time field.
  /// </summary>
  wdFieldTime = unchecked((int)32),
  /// <summary>
  /// Page field.
  /// </summary>
  wdFieldPage = unchecked((int)33),
  /// <summary>
  /// = (Formula) field.
  /// </summary>
  wdFieldExpression = unchecked((int)34),
  /// <summary>
  /// Quote field.
  /// </summary>
  wdFieldQuote = unchecked((int)35),
  /// <summary>
  /// Include field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  wdFieldInclude = unchecked((int)36),
  /// <summary>
  /// PageRef field.
  /// </summary>
  wdFieldPageRef = unchecked((int)37),
  /// <summary>
  /// Ask field.
  /// </summary>
  wdFieldAsk = unchecked((int)38),
  /// <summary>
  /// Fill-In field.
  /// </summary>
  wdFieldFillIn = unchecked((int)39),
  /// <summary>
  /// Data field.
  /// </summary>
  wdFieldData = unchecked((int)40),
  /// <summary>
  /// Next field.
  /// </summary>
  wdFieldNext = unchecked((int)41),
  /// <summary>
  /// NextIf field.
  /// </summary>
  wdFieldNextIf = unchecked((int)42),
  /// <summary>
  /// SkipIf field.
  /// </summary>
  wdFieldSkipIf = unchecked((int)43),
  /// <summary>
  /// MergeRec field.
  /// </summary>
  wdFieldMergeRec = unchecked((int)44),
  /// <summary>
  /// DDE field. No longer available through the Field dialog box, but supported for documents created in earlier
  /// versions of Microsoft Word.
  /// </summary>
  wdFieldDDE = unchecked((int)45),
  /// <summary>
  /// DDEAuto field. No longer available through the Field dialog box, but supported for documents created in
  /// earlier versions of Microsoft Word.
  /// </summary>
  wdFieldDDEAuto = unchecked((int)46),
  /// <summary>
  /// Glossary field. No longer supported in Microsoft Word.
  /// </summary>
  wdFieldGlossary = unchecked((int)47),
  /// <summary>
  /// Print field.
  /// </summary>
  wdFieldPrint = unchecked((int)48),
  /// <summary>
  /// EQ (Equation) field.
  /// </summary>
  wdFieldFormula = unchecked((int)49),
  /// <summary>
  /// GoToButton field. wdFieldMacroButton51 MacroButton field. wdFieldAutoNumOutline52 AutoNumOut field.
  /// wdFieldAutoNumLegal53 AutoNumLgl field.
  /// </summary>
  wdFieldGoToButton = unchecked((int)50),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldMacroButton = unchecked((int)51),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldAutoNumOutline = unchecked((int)52),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldAutoNumLegal = unchecked((int)53),
  /// <summary>
  /// AutoNum field.
  /// </summary>
  wdFieldAutoNum = unchecked((int)54),
  /// <summary>
  /// Import field. Cannot be added through the Field dialog box, but can be added interactively or through code.
  /// </summary>
  wdFieldImport = unchecked((int)55),
  /// <summary>
  /// Link field.
  /// </summary>
  wdFieldLink = unchecked((int)56),
  /// <summary>
  /// Symbol field.
  /// </summary>
  wdFieldSymbol = unchecked((int)57),
  /// <summary>
  /// Embedded field.
  /// </summary>
  wdFieldEmbed = unchecked((int)58),
  /// <summary>
  /// MergeField field.
  /// </summary>
  wdFieldMergeField = unchecked((int)59),
  /// <summary>
  /// UserName field.
  /// </summary>
  wdFieldUserName = unchecked((int)60),
  /// <summary>
  /// UserInitials field.
  /// </summary>
  wdFieldUserInitials = unchecked((int)61),
  /// <summary>
  /// UserAddress field.
  /// </summary>
  wdFieldUserAddress = unchecked((int)62),
  /// <summary>
  /// BarCode field.
  /// </summary>
  wdFieldBarCode = unchecked((int)63),
  /// <summary>
  /// DocVariable field.
  /// </summary>
  wdFieldDocVariable = unchecked((int)64),
  /// <summary>
  /// Section field.
  /// </summary>
  wdFieldSection = unchecked((int)65),
  /// <summary>
  /// SectionPages field. wdFieldIncludePicture67 IncludePicture field.
  /// </summary>
  wdFieldSectionPages = unchecked((int)66),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldIncludePicture = unchecked((int)67),
  /// <summary>
  /// IncludeText field.
  /// </summary>
  wdFieldIncludeText = unchecked((int)68),
  /// <summary>
  /// FileSize field.
  /// </summary>
  wdFieldFileSize = unchecked((int)69),
  /// <summary>
  /// FormText field. Inserted with the Text Form Field button on the Forms toolbar rather than through the Fields
  /// dialog box or through code. wdFieldFormCheckBox71 FormCheckBox field. Inserted with the Check Box Form Field
  /// button on the Forms toolbar rather than through the Field dialog box or through code.
  /// </summary>
  wdFieldFormTextInput = unchecked((int)70),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldFormCheckBox = unchecked((int)71),
  /// <summary>
  /// NoteRef field.
  /// </summary>
  wdFieldNoteRef = unchecked((int)72),
  /// <summary>
  /// TOA (Table of Authorities) field.
  /// </summary>
  wdFieldTOA = unchecked((int)73),
  /// <summary>
  /// TOA (Table of Authorities Entry) field.
  /// </summary>
  wdFieldTOAEntry = unchecked((int)74),
  /// <summary>
  /// MergeSeq field.
  /// </summary>
  wdFieldMergeSeq = unchecked((int)75),
  /// <summary>
  /// Private field.
  /// </summary>
  wdFieldPrivate = unchecked((int)77),
  /// <summary>
  /// Database field.
  /// </summary>
  wdFieldDatabase = unchecked((int)78),
  /// <summary>
  /// AutoText field.
  /// </summary>
  wdFieldAutoText = unchecked((int)79),
  /// <summary>
  /// Compare field.
  /// </summary>
  wdFieldCompare = unchecked((int)80),
  /// <summary>
  /// Add-in field. Not available through the Field dialog box. Used to store data that is hidden from the user
  /// interface.
  /// </summary>
  wdFieldAddin = unchecked((int)81),
  /// <summary>
  /// Subscriber field. wdFieldFormDropDown83 FormDropDown field. Inserted with the Drop-Down Form Field button on
  /// the Forms toolbar rather than through the Field dialog box or through code.
  /// </summary>
  wdFieldSubscriber = unchecked((int)82),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldFormDropDown = unchecked((int)83),
  /// <summary>
  /// Advance field.
  /// </summary>
  wdFieldAdvance = unchecked((int)84),
  /// <summary>
  /// DocProperty field.
  /// </summary>
  wdFieldDocProperty = unchecked((int)85),
  /// <summary>
  /// OCX field. Cannot be added through the Field dialog box, but can be added through code by using the
  /// AddOLEControl method of the FormFields collection.
  /// </summary>
  wdFieldOCX = unchecked((int)87),
  /// <summary>
  /// Hyperlink field.
  /// </summary>
  wdFieldHyperlink = unchecked((int)88),
  /// <summary>
  /// AutoTextList field.
  /// </summary>
  wdFieldAutoTextList = unchecked((int)89),
  /// <summary>
  /// ListNum field.
  /// </summary>
  wdFieldListNum = unchecked((int)90),
  /// <summary>
  /// HTMLActiveX field. Not currently supported.
  /// </summary>
  wdFieldHTMLActiveX = unchecked((int)91),
  /// <summary>
  /// BidiOutline field. wdFieldAddressBlock93 AddressBlock field. wdFieldGreetingLine94 GreetingLine field.
  /// </summary>
  wdFieldBidiOutline = unchecked((int)92),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldAddressBlock = unchecked((int)93),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldGreetingLine = unchecked((int)94),
  /// <summary>
  /// Shape field. Automatically created for any drawn picture.
  /// </summary>
  wdFieldShape = unchecked((int)95),
  /// <summary>
  /// Citation field. wdFieldBibliography97 Bibliography field. wdFieldMergeBarcode98 MergeBarcode field.
  /// wdFieldDisplayBarcode99 DisplayBarcode field.
  /// </summary>
  wdFieldCitation = unchecked((int)96),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldBibliography = unchecked((int)97),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldMergeBarcode = unchecked((int)98),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldDisplayBarcode = unchecked((int)99),
  /// <summary>
  /// Specifies a Microsoft Word field.
  /// </summary>
  wdFieldEmpty = unchecked((int)-1)
}
