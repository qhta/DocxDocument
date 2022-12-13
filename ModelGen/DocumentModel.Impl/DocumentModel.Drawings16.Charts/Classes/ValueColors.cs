namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public class ValueColorsImpl: ModelElementImpl, ValueColors
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ValueColorsImpl(): base() {}
  
  public ValueColorsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MinColorSolidColorFillProperties? MinColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MidColorSolidColorFillProperties? MidColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
