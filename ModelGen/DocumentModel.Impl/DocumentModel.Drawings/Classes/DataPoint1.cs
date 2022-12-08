namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public class DataPoint1Impl: ModelElementImpl, DataPoint1
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx
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
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
