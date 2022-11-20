namespace DocumentModel.Presentation;

/// <summary>
/// Embedded Control.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPicture))]
public class Control: IControl
{
  /// <summary>
  /// spid
  /// </summary>
  public string? ShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// showAsIcon
  /// </summary>
  public bool? ShowAsIcon
  {
    get;
    set;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// imgW
  /// </summary>
  public int? ImageWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// imgH
  /// </summary>
  public int? ImageHeight
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
  
  /// <summary>
  /// Picture.
  /// </summary>
  public DocumentModel.Presentation.IPicture? Picture
  {
    get;
    set;
  }
  
}
