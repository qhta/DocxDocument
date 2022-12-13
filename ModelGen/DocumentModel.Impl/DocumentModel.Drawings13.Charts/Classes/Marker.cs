namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the Marker Class.
/// </summary>
public class MarkerImpl: ModelElementImpl, Marker
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MarkerImpl(): base() {}
  
  public MarkerImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Symbol.
  /// </summary>
  public DocumentModel.Drawings.Charts.MarkerStyleKind? Symbol
  {
    get => (DocumentModel.Drawings.Charts.MarkerStyleKind?)OpenXmlElement?.Symbol?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Symbol != null)
        {
          if (value is not null)
            OpenXmlElement.Symbol.Val = (DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues?)value;
          else
            OpenXmlElement.Symbol = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Symbol = new DocumentFormat.OpenXml.Drawing.Charts.Symbol{ Val = (DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Size.
  /// </summary>
  public Byte? Size
  {
    get => (System.Byte?)OpenXmlElement?.Size?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Size != null)
        {
          if (value is not null)
            OpenXmlElement.Size.Val = (System.Byte?)value;
          else
            OpenXmlElement.Size = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Size = new DocumentFormat.OpenXml.Drawing.Charts.Size{ Val = (System.Byte?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
