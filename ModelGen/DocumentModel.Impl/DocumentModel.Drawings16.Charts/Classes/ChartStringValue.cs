namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ChartStringValue Class.
/// </summary>
public class ChartStringValueImpl: ModelElementImpl, ChartStringValue
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartStringValueImpl(): base() {}
  
  public ChartStringValueImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Index = (System.UInt32?)value;
    }
  }
  
}
