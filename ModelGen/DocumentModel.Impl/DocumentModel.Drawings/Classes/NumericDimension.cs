namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public class NumericDimensionImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimension>, NumericDimension
{
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
  
}
