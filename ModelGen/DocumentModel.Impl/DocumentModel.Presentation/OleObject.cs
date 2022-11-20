namespace DocumentModel.Presentation;

/// <summary>
/// Global Element for OLE Objects and Controls.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IOleObjectEmbed))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IOleObjectLink))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPicture))]
public class OleObject: IOleObject
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
  /// progId
  /// </summary>
  public string? ProgId
  {
    get;
    set;
  }
  
}
