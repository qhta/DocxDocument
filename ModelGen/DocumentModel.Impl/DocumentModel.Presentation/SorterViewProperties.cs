namespace DocumentModel.Presentation;

/// <summary>
/// Slide Sorter View Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class SorterViewProperties: ISorterViewProperties
{
  /// <summary>
  /// Show Formatting
  /// </summary>
  public bool? ShowFormatting
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base properties for Slide Sorter View.
  /// </summary>
  public ICommonViewProperties? CommonViewProperties
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
