namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRunRuby Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBookmarkStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlInsRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlDelRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveFromRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveToRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictInsertionRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictDeletionRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBookmarkEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICommentRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICommentRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFromRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveToRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFromRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveToRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISdtContentRunRuby))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISdtEndCharProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISdtProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlInsRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlDelRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveFromRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlMoveToRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictInsertionRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICustomXmlConflictDeletionRangeStart))]
public class SdtRunRuby: ISdtRunRuby
{
  /// <summary>
  /// SdtContentRunRuby.
  /// </summary>
  public ISdtContentRunRuby? SdtContentRunRuby
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the SdtProperties.
  /// </summary>
  public ISdtProperties? SdtProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the SdtEndCharProperties.
  /// </summary>
  public ISdtEndCharProperties? SdtEndCharProperties
  {
    get;
    set;
  }
  
}
