namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Timeline Class.
/// </summary>
public interface Timeline // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// cache, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Cache { get ; set; }
  
  /// <summary>
  /// caption, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Caption { get ; set; }
  
  /// <summary>
  /// showHeader, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? ShowHeader { get ; set; }
  
  /// <summary>
  /// showSelectionLabel, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? ShowSelectionLabel { get ; set; }
  
  /// <summary>
  /// showTimeLevel, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? ShowTimeLevel { get ; set; }
  
  /// <summary>
  /// showHorizontalScrollbar, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? ShowHorizontalScrollbar { get ; set; }
  
  /// <summary>
  /// level, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Level { get ; set; }
  
  /// <summary>
  /// selectionLevel, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? SelectionLevel { get ; set; }
  
  /// <summary>
  /// scrollPosition, this property is only available in Office 2013 and later.
  /// </summary>
  public DateTime? ScrollPosition { get ; set; }
  
  /// <summary>
  /// style, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Style { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
