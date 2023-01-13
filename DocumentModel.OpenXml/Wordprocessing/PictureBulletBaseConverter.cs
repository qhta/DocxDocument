namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
public static class PictureBulletBaseConverter
{
  public static DocumentModel.Vml.Group? GetGroup(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroup(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.Group? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.GroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Group>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.ImageFile? GetImageFile(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetImageFile(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.ImageFile? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ImageFileConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.ImageFile>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Line? GetLine(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLine(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.Line? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.LineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Line>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Oval? GetOval(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.OvalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOval(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.Oval? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.OvalConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Oval>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.PolyLine? GetPolyLine(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPolyLine(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.PolyLine? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.PolyLineConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.PolyLine>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Rectangle? GetRectangle(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRectangle(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.Rectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.RectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Rectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.RoundRectangle? GetRoundRectangle(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRoundRectangle(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.RoundRectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.RoundRectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.RoundRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Shape? GetShape(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.Shape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Shapetype? GetShapetype(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapetype(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement, DocumentModel.Vml.Shapetype? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ShapetypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Shapetype>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.PictureBulletBase? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PictureBulletBase();
      value.Group = GetGroup(openXmlElement);
      value.ImageFile = GetImageFile(openXmlElement);
      value.Line = GetLine(openXmlElement);
      value.Oval = GetOval(openXmlElement);
      value.PolyLine = GetPolyLine(openXmlElement);
      value.Rectangle = GetRectangle(openXmlElement);
      value.RoundRectangle = GetRoundRectangle(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.Shapetype = GetShapetype(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PictureBulletBase? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PictureBulletBase, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroup(openXmlElement, value?.Group);
      SetImageFile(openXmlElement, value?.ImageFile);
      SetLine(openXmlElement, value?.Line);
      SetOval(openXmlElement, value?.Oval);
      SetPolyLine(openXmlElement, value?.PolyLine);
      SetRectangle(openXmlElement, value?.Rectangle);
      SetRoundRectangle(openXmlElement, value?.RoundRectangle);
      SetShape(openXmlElement, value?.Shape);
      SetShapetype(openXmlElement, value?.Shapetype);
      return openXmlElement;
    }
    return default;
  }
}
