namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties for the Paragraph Mark.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColor))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEastAsianLayout))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmphasis))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFitText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunFonts))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHighlight))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IKern))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFontSizeComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILanguages))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBold))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBoldComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IItalic))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IItalicComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICaps))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISmallCaps))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStrike))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDoubleStrike))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IOutline))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShadow))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmboss))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IImprint))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoProof))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISnapToGrid))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVanish))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IWebHidden))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRightToLeftText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IComplexScript))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISpecVanish))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IOfficeMath))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraphMarkRunPropertiesChange))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IShading))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISpacing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPosition))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunStyle))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextEffect))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICharacterScale))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInserted))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeleted))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFrom))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveTo))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IConflictInsertion))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IConflictDeletion))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IUnderline))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IVerticalTextAlignment))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IFillTextEffect))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IGlow))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ILigatures))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.INumberingFormat))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.INumberSpacing))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IContextualAlternatives))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IProperties3D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IReflection))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IScene3D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IShadow))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IStylisticSets))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ITextOutlineEffect))]
public class ParagraphMarkRunProperties: IParagraphMarkRunProperties
{
  /// <summary>
  /// Inserted Paragraph.
  /// </summary>
  public IInserted? Inserted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Deleted Paragraph.
  /// </summary>
  public IDeleted? Deleted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Move Source Paragraph.
  /// </summary>
  public IMoveFrom? MoveFrom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Move Destination Paragraph.
  /// </summary>
  public DocumentModel.Wordprocessing.IMoveTo? MoveTo
  {
    get;
    set;
  }
  
}
