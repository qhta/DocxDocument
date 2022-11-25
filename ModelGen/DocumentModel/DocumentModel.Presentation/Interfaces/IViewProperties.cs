namespace DocumentModel.Presentation;

/// <summary>
/// Presentation-wide View Properties.
/// </summary>
public interface IViewProperties // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Last View
  /// </summary>
  public DocumentModel.Presentation.ViewKind? LastView { get ; set; }
  
  /// <summary>
  /// Show Comments
  /// </summary>
  public System.Boolean? ShowComments { get ; set; }
  
  /// <summary>
  /// Normal View Properties.
  /// </summary>
  public DocumentModel.Presentation.INormalViewProperties? NormalViewProperties { get ; set; }
  
  /// <summary>
  /// Slide View Properties.
  /// </summary>
  public DocumentModel.Presentation.ISlideViewProperties? SlideViewProperties { get ; set; }
  
  /// <summary>
  /// Outline View Properties.
  /// </summary>
  public DocumentModel.Presentation.IOutlineViewProperties? OutlineViewProperties { get ; set; }
  
  /// <summary>
  /// Notes Text View Properties.
  /// </summary>
  public DocumentModel.Presentation.INotesTextViewProperties? NotesTextViewProperties { get ; set; }
  
  /// <summary>
  /// Slide Sorter View Properties.
  /// </summary>
  public DocumentModel.Presentation.ISorterViewProperties? SorterViewProperties { get ; set; }
  
  /// <summary>
  /// Notes View Properties.
  /// </summary>
  public DocumentModel.Presentation.INotesViewProperties? NotesViewProperties { get ; set; }
  
  /// <summary>
  /// Grid Spacing.
  /// </summary>
  public DocumentModel.Presentation.IPositiveSize2DType? GridSpacing { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
