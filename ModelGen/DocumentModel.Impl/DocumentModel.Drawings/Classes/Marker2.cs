namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public class Marker2Impl: ModelElementImpl, Marker2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Symbol.
  /// </summary>
  public MarkerStyleKind? Symbol
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
        return (MarkerStyleKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.Symbol{ Val = (DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Size.
  /// </summary>
  public Byte? Size
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
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
