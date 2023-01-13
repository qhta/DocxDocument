namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// VML Object.
/// </summary>
public static class PictureConverter
{
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public static Byte[]? GetAnchorId(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    if (openXmlElement?.AnchorId?.Value != null)
      return Convert.FromHexString(openXmlElement.AnchorId.Value);
    return null;
  }
  
  public static void SetAnchorId(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.AnchorId = Convert.ToHexString(value);
      else
        openXmlElement.AnchorId = null;
    }
  }
  
  public static DocumentModel.Vml.Group? GetGroup(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGroup(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.Group? value)
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
  
  public static DocumentModel.Vml.ImageFile? GetImageFile(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetImageFile(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.ImageFile? value)
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
  
  public static DocumentModel.Vml.Line? GetLine(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLine(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.Line? value)
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
  
  public static DocumentModel.Vml.Oval? GetOval(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.OvalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOval(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.Oval? value)
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
  
  public static DocumentModel.Vml.PolyLine? GetPolyLine(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPolyLine(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.PolyLine? value)
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
  
  public static DocumentModel.Vml.Rectangle? GetRectangle(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRectangle(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.Rectangle? value)
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
  
  public static DocumentModel.Vml.RoundRectangle? GetRoundRectangle(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRoundRectangle(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.RoundRectangle? value)
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
  
  public static DocumentModel.Vml.Shape? GetShape(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.Shape? value)
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
  
  public static DocumentModel.Vml.Shapetype? GetShapetype(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapetype(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.Shapetype? value)
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
  
  public static DocumentModel.Vml.Arc? GetArc(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ArcConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetArc(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.Arc? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ArcConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Arc>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.Curve? GetCurve(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.CurveConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCurve(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.Curve? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.CurveConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Curve>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.OleObject? GetOleObject(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.OleObject>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.OleObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOleObject(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Vml.OleObject? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.OleObject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.OleObjectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.OleObject>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.RelationshipType? GetMovieReference(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MovieReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMovieReference(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MovieReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.RelationshipTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MovieReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Control? GetControl(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Control>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControl(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement, DocumentModel.Wordprocessing.Control? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Control>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.ControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Control>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.Picture? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Picture? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Picture();
      value.AnchorId = GetAnchorId(openXmlElement);
      value.Group = GetGroup(openXmlElement);
      value.ImageFile = GetImageFile(openXmlElement);
      value.Line = GetLine(openXmlElement);
      value.Oval = GetOval(openXmlElement);
      value.PolyLine = GetPolyLine(openXmlElement);
      value.Rectangle = GetRectangle(openXmlElement);
      value.RoundRectangle = GetRoundRectangle(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.Shapetype = GetShapetype(openXmlElement);
      value.Arc = GetArc(openXmlElement);
      value.Curve = GetCurve(openXmlElement);
      value.OleObject = GetOleObject(openXmlElement);
      value.MovieReference = GetMovieReference(openXmlElement);
      value.Control = GetControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Picture? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Picture, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAnchorId(openXmlElement, value?.AnchorId);
      SetGroup(openXmlElement, value?.Group);
      SetImageFile(openXmlElement, value?.ImageFile);
      SetLine(openXmlElement, value?.Line);
      SetOval(openXmlElement, value?.Oval);
      SetPolyLine(openXmlElement, value?.PolyLine);
      SetRectangle(openXmlElement, value?.Rectangle);
      SetRoundRectangle(openXmlElement, value?.RoundRectangle);
      SetShape(openXmlElement, value?.Shape);
      SetShapetype(openXmlElement, value?.Shapetype);
      SetArc(openXmlElement, value?.Arc);
      SetCurve(openXmlElement, value?.Curve);
      SetOleObject(openXmlElement, value?.OleObject);
      SetMovieReference(openXmlElement, value?.MovieReference);
      SetControl(openXmlElement, value?.Control);
      return openXmlElement;
    }
    return default;
  }
}
