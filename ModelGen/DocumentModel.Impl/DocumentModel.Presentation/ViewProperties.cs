namespace DocumentModel.Presentation;

/// <summary>
/// Presentation-wide View Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IGridSpacing))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INormalViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INotesTextViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INotesViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IOutlineViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISorterViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideViewProperties))]
public class ViewProperties: IViewProperties
{
  /// <summary>
  /// Last View
  /// </summary>
  public DocumentModel.Presentation.ViewValues? LastView
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Comments
  /// </summary>
  public bool? ShowComments
  {
    get;
    set;
  }
  
  /// <summary>
  /// Normal View Properties.
  /// </summary>
  public INormalViewProperties? NormalViewProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Slide View Properties.
  /// </summary>
  public ISlideViewProperties? SlideViewProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline View Properties.
  /// </summary>
  public IOutlineViewProperties? OutlineViewProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Notes Text View Properties.
  /// </summary>
  public INotesTextViewProperties? NotesTextViewProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Slide Sorter View Properties.
  /// </summary>
  public ISorterViewProperties? SorterViewProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Notes View Properties.
  /// </summary>
  public INotesViewProperties? NotesViewProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Grid Spacing.
  /// </summary>
  public IGridSpacing? GridSpacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
