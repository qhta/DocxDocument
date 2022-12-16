namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericValue Class.
/// </summary>
public class NumericValueImpl: ModelElementImpl, NumericValue
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NumericValueImpl(): base() {}
  
  public NumericValueImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx
  {
    get => (System.UInt32?)OpenXmlElement?.Idx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Idx = (System.UInt32?)value;
    }
  }
  
}
