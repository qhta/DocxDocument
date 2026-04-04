using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents application and document options in Microsoft Word. Many of the properties for the Options object correspond to items in the Options dialog box (Tools menu).
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options?view=word-pia"/>
public partial interface IOptions : IModelObject
{

  /// <summary> 
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.alwaysusecleartype?view=word-pia"/>
  public bool? AlwaysUseClearType { get; set; }

  /// <summary> 
  /// True if Microsoft Word animates mouse movements, uses animated cursors, and animates actions such as 
  /// background saving and find and replace operations. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.animatescreenmovements?view=word-pia"/>
  public bool? AnimateScreenMovements { get; set; }

  /// <summary> 
  /// True if Microsoft Word displays text as white characters on a blue background. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.bluescreen?view=word-pia"/>
  public bool? BlueScreen { get; set; }

  /// <summary> 
  /// Returns or sets a ColorIndex constant that represents the color of comments in a document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.commentscolor?view=word-pia"/>
  public ColorIndex? CommentsColor { get; set; }

  /// <summary> 
  /// Returns or sets the default 24-bit color to use for new Border objects. Can be any valid Color constant or 
  /// a value returned by Visual Basic's RGB function. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultbordercolor?view=word-pia"/>
  public RgbColor? DefaultBorderColor { get; set; }

  /// <summary> 
  /// Returns or sets the default line color for borders. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultbordercolorindex?view=word-pia"/>
  public ColorIndex? DefaultBorderColorIndex { get; set; }

  /// <summary> 
  /// Returns or sets the default border line style. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultborderlinestyle?view=word-pia"/>
  public LineStyle? DefaultBorderLineStyle { get; set; }

  /// <summary> 
  /// Returns or sets the default line width of borders. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaultborderlinewidth?view=word-pia"/>
  public LineWidth? DefaultBorderLineWidth { get; set; }

  /// <summary> 
  /// Returns or sets the color used to highlight text formatted with the Highlight button (Formatting toolbar). 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.defaulthighlightcolorindex?view=word-pia"/>
  public ColorIndex? DefaultHighlightColorIndex { get; set; }

  /// <summary> 
  /// Returns or sets a CellColor constant that represents the color for a deleted cell. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedcellcolor?view=word-pia"/>
  public CellColor? DeletedCellColor { get; set; }

  /// <summary> 
  /// Returns or sets the color of text that is deleted while change tracking is enabled. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedtextcolor?view=word-pia"/>
  public ColorIndex? DeletedTextColor { get; set; }

  /// <summary> 
  /// Returns or sets the format of text that is deleted while change tracking is enabled. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.deletedtextmark?view=word-pia"/>
  public DeletedTextMark? DeletedTextMark { get; set; }

  /// <summary> 
  /// Returns or sets the 24-bit color to be used for diacritics in a right-to-left language document. Can be any 
  /// valid Color constant or a value returned by Visual Basic's RGB function. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.diacriticcolorval?view=word-pia"/>
  public RgbColor? DiacriticColorVal { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean (bool in C#) that specifies whether alignment guides are enabled in the user 
  /// interface. Read-write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displayalignmentguides?view=word-pia"/>
  public bool? DisplayAlignmentGuides { get; set; }

  /// <summary> 
  /// True if Microsoft Word displays the document grid. This property is the equivalent of the Gridlines command 
  /// on the View menu. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaygridlines?view=word-pia"/>
  public bool? DisplayGridLines { get; set; }

  /// <summary> 
  /// True for Microsoft Word to display the Paste Options button, which displays directly under newly pasted 
  /// text. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaypasteoptions?view=word-pia"/>
  public bool? DisplayPasteOptions { get; set; }

  /// <summary> 
  /// True for Microsoft Word to display a button directly above a smart tag when a mouse pointer is positioned 
  /// over it. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.displaysmarttagbuttons?view=word-pia"/>
  public bool? DisplaySmartTagButtons { get; set; }

  /// <summary> 
  /// Returns or sets the amount of horizontal space between the invisible gridlines that Microsoft Word uses when 
  /// you draw, move, and resize AutoShapes or East Asian characters in new documents. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.griddistancehorizontal?view=word-pia"/>
  public float? GridDistanceHorizontal { get; set; }

  /// <summary> 
  /// Returns or sets the amount of vertical space between the invisible gridlines that Microsoft Word uses when 
  /// you draw, move, and resize AutoShapes or East Asian characters in new documents. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.griddistancevertical?view=word-pia"/>
  public float? GridDistanceVertical { get; set; }

  /// <summary> 
  /// Returns or sets the point, relative to the left edge of the page, where you want the invisible grid for 
  /// drawing, moving, and resizing AutoShapes or East Asian characters to begin in new documents. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.gridoriginhorizontal?view=word-pia"/>
  public float? GridOriginHorizontal { get; set; }

  /// <summary> 
  /// Returns or sets the point, relative to the top of the page, where you want the invisible grid for drawing, 
  /// moving, and resizing AutoShapes or East Asian characters to begin in new documents. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.gridoriginvertical?view=word-pia"/>
  public float? GridOriginVertical { get; set; }

  /// <summary> 
  /// Returns or sets a CellColor constant that represents the color for an inserted table cell. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedcellcolor?view=word-pia"/>
  public CellColor? InsertedCellColor { get; set; }

  /// <summary> 
  /// Returns or sets the color of text that is inserted while change tracking is enabled. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedtextcolor?view=word-pia"/>
  public ColorIndex? InsertedTextColor { get; set; }

  /// <summary> 
  /// Returns or sets how Microsoft Word formats inserted text while change tracking is enabled (the 
  /// TrackRevisions property is True). 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.insertedtextmark?view=word-pia"/>
  public InsertedTextMark? InsertedTextMark { get; set; }

  /// <summary> 
  /// True for Microsoft Word to mark text in documents with smart tag information. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.labelsmarttags?view=word-pia"/>
  public bool? LabelSmartTags { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean (bool in C#) that specifies whether margin alignment guides are displayed in the 
  /// user interface. Read-write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.marginalignmentguides?view=word-pia"/>
  public bool? MarginAlignmentGuides { get; set; }

  /// <summary> 
  /// Returns or sets a CellColor constant that represents the color for merged table cells. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.mergedcellcolor?view=word-pia"/>
  public CellColor? MergedCellColor { get; set; }

  /// <summary> 
  /// Returns or sets a ColorIndex constant that represents the color of moved text. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movefromtextcolor?view=word-pia"/>
  public ColorIndex? MoveFromTextColor { get; set; }

  /// <summary> 
  /// Returns or sets a MoveFromTextMark constant that represents the type of revision mark to use for moved 
  /// text. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movefromtextmark?view=word-pia"/>
  public MoveFromTextMark? MoveFromTextMark { get; set; }

  /// <summary> 
  /// Returns or sets a ColorIndex constant that represents the color of moved text. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movetotextcolor?view=word-pia"/>
  public ColorIndex? MoveToTextColor { get; set; }

  /// <summary> 
  /// Returns or sets a MoveToTextMark constant that represents the type of revision mark to use for moved text. 
  /// Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.movetotextmark?view=word-pia"/>
  public MoveToTextMark? MoveToTextMark { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether Microsoft Office Word automatically converts equations to 
  /// professional format. True indicates that Word automatically converts equations to professional format. 
  /// Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.omathautobuildup?view=word-pia"/>
  public bool? OMathAutoBuildUp { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents how equations are represented in plain text. True indicates 
  /// equations are represented in Linear Format. False indicates equations are represented in MathML. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.omathcopylf?view=word-pia"/>
  public bool? OMathCopyLF { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean (bool in C#) that specifies whether page alignment guides are displayed in the 
  /// user interface. Read-write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.pagealignmentguides?view=word-pia"/>
  public bool? PageAlignmentGuides { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean (bool in C#) that specifies whether paragraph alignment guides are displayed in 
  /// the user interface. Read-write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.paragraphalignmentguides?view=word-pia"/>
  public bool? ParagraphAlignmentGuides { get; set; }

  /// <summary> 
  /// Sets or returns a WrapTypeMerged constant that indicates how Microsoft Word wraps text around pictures. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.picturewraptype?view=word-pia"/>
  public WrapTypeMerged? PictureWrapType { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether Word optimizes character positioning for print layout 
  /// rather than on-screen readability. True disables the default setting that compresses character spacing to 
  /// facilitate on-screen readability and enables character spacing for print media. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.precisepositioning?view=word-pia"/>
  public bool? PrecisePositioning { get; set; }

  /// <summary> 
  /// Returns or sets the color of changed lines in a document with tracked changes. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedlinescolor?view=word-pia"/>
  public ColorIndex? RevisedLinesColor { get; set; }

  /// <summary> 
  /// Returns or sets the placement of changed lines in a document with tracked changes. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedlinesmark?view=word-pia"/>
  public RevisedLinesMark? RevisedLinesMark { get; set; }

  /// <summary> 
  /// Returns or sets the color used to mark formatting changes while change tracking is enabled. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedpropertiescolor?view=word-pia"/>
  public ColorIndex? RevisedPropertiesColor { get; set; }

  /// <summary> 
  /// Returns or sets the mark used to show formatting changes while change tracking is enabled. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisedpropertiesmark?view=word-pia"/>
  public RevisedPropertiesMark? RevisedPropertiesMark { get; set; }

  /// <summary> 
  /// Returns or sets a RevisionsBalloonPrintOrientation constant that represents the direction of revision and 
  /// comment balloons when they are printed. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.revisionsballoonprintorientation?view=word-pia"/>
  public RevisionsBalloonPrintOrientation? RevisionsBalloonPrintOrientation { get; set; }

  /// <summary> 
  /// You have requested Help for a keyword used only on the Macintosh. For information about this keyword, 
  /// consult the language reference Help included with Microsoft Office Macintosh Edition. 
  /// </summary> 
  /// <remarks>This option works only on the Macintosh.</remarks> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.shortmenunames?view=word-pia"/>
  public bool? ShortMenuNames { get; set; }

  /// <summary> 
  /// True if bidirectional control characters are visible in the current document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showcontrolcharacters?view=word-pia"/>
  public bool? ShowControlCharacters { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether the Developer tab is displayed in the Ribbon. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showdevtools?view=word-pia"/>
  public bool? ShowDevTools { get; set; }

  /// <summary> 
  /// True if diacritics are visible in a right-to-left language document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showdiacritics?view=word-pia"/>
  public bool? ShowDiacritics { get; set; }

  /// <summary> 
  /// True for Microsoft Word to mark inconsistencies in formatting by placing a squiggly underline beneath text 
  /// formatted similarly to other formatting that is used more frequently in a document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showformaterror?view=word-pia"/>
  public bool? ShowFormatError { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether Microsoft Word displays hidden markup when opening or 
  /// saving a file. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showmarkupopensave?view=word-pia"/>
  public bool? ShowMarkupOpenSave { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether to display mini toolbars when the user right- clicks in 
  /// the document window. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showmenufloaties?view=word-pia"/>
  public bool? ShowMenuFloaties { get; set; }

  /// <summary> 
  /// True if Microsoft Word displays a list of summary statistics, including measures of readability, when it has 
  /// finished checking grammar. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showreadabilitystatistics?view=word-pia"/>
  public bool? ShowReadabilityStatistics { get; set; }

  /// <summary> 
  /// Returns or sets a Boolean that represents whether mini toolbars display when a user selects text. 
  /// Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.showselectionfloaties?view=word-pia"/>
  public bool? ShowSelectionFloaties { get; set; }

  /// <summary> 
  /// True if AutoShapes or East Asian characters are automatically aligned with an invisible grid when they are 
  /// drawn, moved, or resized in new documents. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.snaptogrid?view=word-pia"/>
  public bool? SnapToGrid { get; set; }

  /// <summary> 
  /// True if Microsoft Word automatically aligns AutoShapes or East Asian characters with invisible gridlines 
  /// that go through the vertical and horizontal edges of other AutoShapes or East Asian characters in new 
  /// documents. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.snaptoshapes?view=word-pia"/>
  public bool? SnapToShapes { get; set; }

  /// <summary> 
  /// Returns or sets a CellColor that represents the color for split table cells. Read/write. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.splitcellcolor?view=word-pia"/>
  public CellColor? SplitCellColor { get; set; }

  /// <summary> 
  /// True if you can set the color of diacritics in the current document. 
  /// </summary> 
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.options.usediffdiaccolor?view=word-pia"/>
  public bool? UseDiffDiacColor { get; set; }

}
