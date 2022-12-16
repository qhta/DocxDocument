namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Marker.
/// </summary>
public class MarkerImpl: ModelElementImpl, Marker
{
  public DocumentFormat.OpenXml.Drawing.Charts.Marker? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Marker?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MarkerImpl(): base() {}
  
  public MarkerImpl(DocumentFormat.OpenXml.Drawing.Charts.Marker openXmlElement): base(openXmlElement)
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ChartShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ChartShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
