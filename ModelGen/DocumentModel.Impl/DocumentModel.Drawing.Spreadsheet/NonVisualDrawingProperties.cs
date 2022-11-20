namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Drawing Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlinkOnClick))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IHyperlinkOnHover))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualDrawingPropertiesExtensionList))]
public class NonVisualDrawingProperties: INonVisualDrawingProperties
{
  /// <summary>
  /// id
  /// </summary>
  public uint? Id
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
  /// descr
  /// </summary>
  public string? Description
  {
    get;
    set;
  }
  
  /// <summary>
  /// hidden
  /// </summary>
  public bool? Hidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// title
  /// </summary>
  public string? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// HyperlinkOnClick.
  /// </summary>
  public IHyperlinkOnClick? HyperlinkOnClick
  {
    get;
    set;
  }
  
  /// <summary>
  /// HyperlinkOnHover.
  /// </summary>
  public IHyperlinkOnHover? HyperlinkOnHover
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualDrawingPropertiesExtensionList.
  /// </summary>
  public INonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get;
    set;
  }
  
}
