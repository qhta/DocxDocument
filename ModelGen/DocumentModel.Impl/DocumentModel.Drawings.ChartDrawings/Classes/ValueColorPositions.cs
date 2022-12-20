namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public partial class ValueColorPositionsImpl: ModelElementImpl, ValueColorPositions
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ValueColorPositionsImpl(): base() {}
  
  public ValueColorPositionsImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? Count
  {
    get => (System.Int32?)OpenXmlElement?.Count?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Count = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MinValueColorEndPosition? MinValueColorEndPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.MinValueColorEndPositionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinValueColorEndPosition>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.MinValueColorEndPositionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? ValueColorMiddlePosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePositionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePositionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? MaxValueColorEndPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPositionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPositionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
