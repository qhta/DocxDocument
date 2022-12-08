namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public class TrendlineImpl: ModelElementImpl, Trendline
{
  public DocumentFormat.OpenXml.Drawing.Charts.Trendline? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Trendline?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Trendline Name.
  /// </summary>
  public String? TrendlineName
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  public TrendlineKind? TrendlineType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType>();
        return (TrendlineKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.TrendlineType{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  public Byte? PolynomialOrder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Period.
  /// </summary>
  public UInt32? Period
  {
    get;
    set;
  }
  
  /// <summary>
  /// Forward.
  /// </summary>
  public Double? Forward
  {
    get;
    set;
  }
  
  /// <summary>
  /// Backward.
  /// </summary>
  public Double? Backward
  {
    get;
    set;
  }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  public Double? Intercept
  {
    get;
    set;
  }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  public Boolean? DisplayRSquaredValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  public Boolean? DisplayEquation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  public TrendlineLabel1? TrendlineLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
