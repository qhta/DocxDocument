namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public class StringDimensionImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension>, StringDimension
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public StringDimensionType? Type
  {
    get => (StringDimensionType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType?)value;
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
