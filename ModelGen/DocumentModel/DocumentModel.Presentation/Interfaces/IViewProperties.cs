namespace DocumentModel.Presentation;

/// <summary>
/// Presentation-wide View Properties.
/// </summary>
public interface IViewProperties // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Last View
  /// </summary>
  public ViewValues? LastView { get ; set; }
  
  /// <summary>
  /// Show Comments
  /// </summary>
  public Boolean? ShowComments { get ; set; }
  
  /// <summary>
  /// Normal View Properties.
  /// </summary>
  public INormalViewProperties? NormalViewProperties { get ; set; }
  
  /// <summary>
  /// Slide View Properties.
  /// </summary>
  public ISlideViewProperties? SlideViewProperties { get ; set; }
  
  /// <summary>
  /// Outline View Properties.
  /// </summary>
  public IOutlineViewProperties? OutlineViewProperties { get ; set; }
  
  /// <summary>
  /// Notes Text View Properties.
  /// </summary>
  public INotesTextViewProperties? NotesTextViewProperties { get ; set; }
  
  /// <summary>
  /// Slide Sorter View Properties.
  /// </summary>
  public ISorterViewProperties? SorterViewProperties { get ; set; }
  
  /// <summary>
  /// Notes View Properties.
  /// </summary>
  public INotesViewProperties? NotesViewProperties { get ; set; }
  
  /// <summary>
  /// Grid Spacing.
  /// </summary>
  public IGridSpacing? GridSpacing { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
  /// <summary>
  /// Gets the ViewPropertiesPart associated with this element.
  /// </summary>
  public ViewPropertiesPart? ViewPropertiesPart { get ; set; }
  
}
