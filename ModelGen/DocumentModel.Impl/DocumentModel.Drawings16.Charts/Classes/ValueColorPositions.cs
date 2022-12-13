namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public class ValueColorPositionsImpl: ModelElementImpl, ValueColorPositions
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ValueColorPositionsImpl(): base() {}
  
  public ValueColorPositionsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? Count
  {
    get => (System.Int32?)OpenXmlElement?.Count?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Count = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MinValueColorEndPosition? MinValueColorEndPosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ValueColorMiddlePosition? ValueColorMiddlePosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MaxValueColorEndPosition? MaxValueColorEndPosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
