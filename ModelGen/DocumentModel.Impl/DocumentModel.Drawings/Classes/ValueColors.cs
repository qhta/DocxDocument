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
    get;
    set;
  }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public MidColorSolidColorFillProperties? MidColorSolidColorFillProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties
  {
    get;
    set;
  }
  
}
