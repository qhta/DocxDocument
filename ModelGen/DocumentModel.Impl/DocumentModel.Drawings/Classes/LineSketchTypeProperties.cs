namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSketchTypeProperties Class.
/// </summary>
public class LineSketchTypePropertiesImpl: ModelElementImpl, LineSketchTypeProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineSketchTypePropertiesImpl(): base() {}
  
  public LineSketchTypePropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchTypeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  public Boolean? LineSketchNoneEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// LineSketchCurvedEmpty.
  /// </summary>
  public Boolean? LineSketchCurvedEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// LineSketchFreehandEmpty.
  /// </summary>
  public Boolean? LineSketchFreehandEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// LineSketchScribbleEmpty.
  /// </summary>
  public Boolean? LineSketchScribbleEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
