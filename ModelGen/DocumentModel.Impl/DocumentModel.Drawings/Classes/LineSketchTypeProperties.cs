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
  
  /// <summary>
  /// LineSketchNoneEmpty.
  /// </summary>
  public Boolean? LineSketchNoneEmpty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchNoneEmpty();
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchCurvedEmpty();
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchFreehandEmpty();
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.Drawing.SketchyShapes.LineSketchScribbleEmpty();
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
