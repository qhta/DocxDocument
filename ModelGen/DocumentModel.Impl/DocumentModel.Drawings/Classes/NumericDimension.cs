namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public class NumericDimensionImpl: ModelElementImpl, NumericDimension
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public NumericDimensionType? Type
  {
    get => (NumericDimensionType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType?)value;
    }
  }
  
  public OpenXmlFormulaElement? Formula
  {
    get;
    set;
  }
  
  public OpenXmlFormulaElement? NfFormula
  {
    get;
    set;
  }
  
  public Collection<NumericLevel>? NumericLevels
  {
    get;
    set;
  }
  
}
