namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public MinColorSolidColorFillProperties? MinColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public MidColorSolidColorFillProperties? MidColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
