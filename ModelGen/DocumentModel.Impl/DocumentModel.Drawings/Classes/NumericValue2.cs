namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumericValue Class.
/// </summary>
public class NumericValue2Impl: ModelElementImpl, NumericValue2
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx
  {
    get => (UInt32?)OpenXmlElement?.Idx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Idx = (System.UInt32?)value;
    }
  }
  
}
