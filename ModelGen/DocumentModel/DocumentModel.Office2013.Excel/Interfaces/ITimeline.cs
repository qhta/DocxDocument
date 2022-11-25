namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the Timeline Class.
/// </summary>
public interface ITimeline // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// cache, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Cache { get ; set; }
  
  /// <summary>
  /// caption, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// showHeader, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? ShowHeader { get ; set; }
  
  /// <summary>
  /// showSelectionLabel, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? ShowSelectionLabel { get ; set; }
  
  /// <summary>
  /// showTimeLevel, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? ShowTimeLevel { get ; set; }
  
  /// <summary>
  /// showHorizontalScrollbar, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? ShowHorizontalScrollbar { get ; set; }
  
  /// <summary>
  /// level, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Level { get ; set; }
  
  /// <summary>
  /// selectionLevel, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? SelectionLevel { get ; set; }
  
  /// <summary>
  /// scrollPosition, this property is only available in Office 2013 and later.
  /// </summary>
  public System.DateTime? ScrollPosition { get ; set; }
  
  /// <summary>
  /// style, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Style { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
