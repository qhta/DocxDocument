namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public partial class ValueColorsImpl: ModelElementImpl, ValueColors
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ValueColorsImpl(): base() {}
  
  public ValueColorsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MinColorSolidColorFillProperties? MinColorSolidColorFillProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.MinColorSolidColorFillPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.MinColorSolidColorFillPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MidColorSolidColorFillProperties? MidColorSolidColorFillProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.MidColorSolidColorFillPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.MidColorSolidColorFillPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.MaxColorSolidColorFillPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.MaxColorSolidColorFillPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
