namespace DocumentModel.Drawings;

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
    get => (Int32?)OpenXmlElement?.Count?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Count = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public MinValueColorEndPosition? MinValueColorEndPosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public ValueColorMiddlePosition? ValueColorMiddlePosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public MaxValueColorEndPosition? MaxValueColorEndPosition
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
