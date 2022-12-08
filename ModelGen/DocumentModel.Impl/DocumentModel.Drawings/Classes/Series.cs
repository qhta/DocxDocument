namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Series Class.
/// </summary>
public class SeriesImpl: ModelElementImpl, Series
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public SeriesLayout? LayoutId
  {
    get => (SeriesLayout?)OpenXmlElement?.LayoutId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LayoutId = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout?)value;
    }
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? OwnerIdx
  {
    get;
    set;
  }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? UniqueId
  {
    get;
    set;
  }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? FormatIdx
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
  public ShapeProperties6? ShapeProperties
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
  
  public Collection<DataPoint1>? DataPoints
  {
    get;
    set;
  }
  
  public DataLabels1? DataLabels
  {
    get;
    set;
  }
  
  public UInt32? DataId
  {
    get;
    set;
  }
  
  public SeriesLayoutProperties? SeriesLayoutProperties
  {
    get;
    set;
  }
  
  public Collection<String>? AxisIds
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
