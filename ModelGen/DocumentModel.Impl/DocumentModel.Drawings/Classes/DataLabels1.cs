namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabels Class.
/// </summary>
public class DataLabels1Impl: ModelElementImpl, DataLabels1
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DataLabelPos? Pos
  {
    get => (DataLabelPos?)OpenXmlElement?.Pos?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pos = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos?)value;
    }
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public NumberFormat? NumberFormat
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
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DataLabelVisibilities? DataLabelVisibilities
  {
    get;
    set;
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public String? SeparatorXsdstring
  {
    get;
    set;
  }
  
  public Collection<DataLabel1>? Items
  {
    get;
    set;
  }
  
  public Collection<DataLabelHidden>? DataLabelHiddens
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
