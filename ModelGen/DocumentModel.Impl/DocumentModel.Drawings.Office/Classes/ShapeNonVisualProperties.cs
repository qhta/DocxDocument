namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public partial class ShapeNonVisualPropertiesImpl: ModelElementImpl, ShapeNonVisualProperties
{
  public DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeNonVisualPropertiesImpl(): base() {}
  
  public ShapeNonVisualPropertiesImpl(DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Office.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Office.NonVisualDrawingShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.NonVisualDrawingShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
