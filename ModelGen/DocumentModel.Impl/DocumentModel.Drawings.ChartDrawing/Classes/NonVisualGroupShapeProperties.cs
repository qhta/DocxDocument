namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Properties.
/// </summary>
public class NonVisualGroupShapePropertiesImpl: ModelElementImpl, NonVisualGroupShapeProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualGroupShapePropertiesImpl(): base() {}
  
  public NonVisualGroupShapePropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Non-Visual Group Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualGroupShapeDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawing.NonVisualGroupShapeDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
