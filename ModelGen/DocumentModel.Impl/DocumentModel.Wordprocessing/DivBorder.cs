namespace DocumentModel.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITopBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILeftBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBottomBorder))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRightBorder))]
public class DivBorder: IDivBorder
{
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.ITopBorder? TopBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.ILeftBorder? LeftBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.IBottomBorder? BottomBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.IRightBorder? RightBorder
  {
    get;
    set;
  }
  
}
