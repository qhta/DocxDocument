namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Series Class.
/// </summary>
public class Series
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public SeriesLayout? LayoutId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public Text1? Text
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public ValueColors? ValueColors
  {
    get;
    set;
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public ValueColorPositions? ValueColorPositions
  {
    get;
    set;
  }
  
  public DataLabels2? DataLabels
  {
    get;
    set;
  }
  
  public SeriesLayoutProperties? SeriesLayoutProperties
  {
    get;
    set;
  }
  
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
