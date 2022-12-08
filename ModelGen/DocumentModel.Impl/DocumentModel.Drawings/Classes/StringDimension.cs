namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public class StringDimensionImpl: ModelElementImpl, StringDimension
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  public Collection<StringLevel>? StringLevels
  {
    get;
    set;
  }
  
}
