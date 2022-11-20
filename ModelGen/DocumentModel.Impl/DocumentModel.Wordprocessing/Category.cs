namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Categorization.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IGallery))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IName))]
public class Category: ICategory
{
  /// <summary>
  /// Category Associated With Entry.
  /// </summary>
  public IName? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gallery Associated With Entry.
  /// </summary>
  public DocumentModel.Wordprocessing.IGallery? Gallery
  {
    get;
    set;
  }
  
}
