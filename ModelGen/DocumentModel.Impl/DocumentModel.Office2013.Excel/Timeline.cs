namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the Timeline Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IExtensionList))]
public class Timeline: ITimeline
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// cache, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Cache
  {
    get;
    set;
  }
  
  /// <summary>
  /// caption, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Caption
  {
    get;
    set;
  }
  
  /// <summary>
  /// showHeader, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? ShowHeader
  {
    get;
    set;
  }
  
  /// <summary>
  /// showSelectionLabel, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? ShowSelectionLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// showTimeLevel, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? ShowTimeLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// showHorizontalScrollbar, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? ShowHorizontalScrollbar
  {
    get;
    set;
  }
  
  /// <summary>
  /// level, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Level
  {
    get;
    set;
  }
  
  /// <summary>
  /// selectionLevel, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? SelectionLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// scrollPosition, this property is only available in Office 2013 and later.
  /// </summary>
  public DateTime? ScrollPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// style, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Excel.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
