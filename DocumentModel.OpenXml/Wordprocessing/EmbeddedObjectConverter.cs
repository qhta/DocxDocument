namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Inline Embedded Object.
/// </summary>
public static class EmbeddedObjectConverter
{
  /// <summary>
  /// dxaOrig
  /// </summary>
  private static String? GetDxaOriginal(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    return openXmlElement?.DxaOriginal?.Value;
  }
  
  private static void SetDxaOriginal(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DxaOriginal = new StringValue { Value = value };
    else
      openXmlElement.DxaOriginal = null;
  }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  private static String? GetDyaOriginal(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    return openXmlElement?.DyaOriginal?.Value;
  }
  
  private static void SetDyaOriginal(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DyaOriginal = new StringValue { Value = value };
    else
      openXmlElement.DyaOriginal = null;
  }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  private static UInt32? GetAnchorId(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    if (openXmlElement.AnchorId?.Value != null)
      return UInt32.Parse(openXmlElement.AnchorId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetAnchorId(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.AnchorId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.AnchorId = null;
  }
  
  private static DocumentModel.Vml.Group? GetGroup(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Group>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.GroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroup(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.Group? value)
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
  
  private static DocumentModel.Vml.ImageFile? GetImageFile(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageFile>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ImageFileConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageFile(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.ImageFile? value)
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
  
  private static DocumentModel.Vml.Line? GetLine(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Line>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.LineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLine(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.Line? value)
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
  
  private static DocumentModel.Vml.Oval? GetOval(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Oval>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.OvalConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOval(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.Oval? value)
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
  
  private static DocumentModel.Vml.PolyLine? GetPolyLine(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.PolyLine>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.PolyLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPolyLine(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.PolyLine? value)
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
  
  private static DocumentModel.Vml.Rectangle? GetRectangle(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Rectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRectangle(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.Rectangle? value)
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
  
  private static DocumentModel.Vml.RoundRectangle? GetRoundRectangle(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.RoundRectangle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.RoundRectangleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRoundRectangle(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.RoundRectangle? value)
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
  
  private static DocumentModel.Vml.Shape? GetShape(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shape>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShape(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.Shape? value)
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
  
  private static DocumentModel.Vml.Shapetype? GetShapetype(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Shapetype>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapetypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapetype(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.Shapetype? value)
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
  
  private static DocumentModel.Vml.Arc? GetArc(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Arc>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ArcConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetArc(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.Arc? value)
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
  
  private static DocumentModel.Vml.Curve? GetCurve(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Curve>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.CurveConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCurve(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.Curve? value)
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
  
  private static DocumentModel.Vml.OleObject? GetOleObject(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.OleObject>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.OleObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOleObject(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Vml.OleObject? value)
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
  
  private static DocumentModel.Wordprocessing.Drawing? GetDrawing(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DrawingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDrawing(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Wordprocessing.Drawing? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Drawing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Drawing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Control? GetControl(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Control>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControl(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Wordprocessing.Control? value)
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
  
  private static DocumentModel.Wordprocessing.ObjectEmbed? GetObjectEmbed(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ObjectEmbedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetObjectEmbed(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Wordprocessing.ObjectEmbed? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ObjectEmbedConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ObjectEmbed>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.ObjectLink? GetObjectLink(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ObjectLink>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ObjectLinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetObjectLink(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject openXmlElement, DocumentModel.Wordprocessing.ObjectLink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ObjectLink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ObjectLinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ObjectLink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.EmbeddedObject? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.EmbeddedObject();
      value.DxaOriginal = GetDxaOriginal(openXmlElement);
      value.DyaOriginal = GetDyaOriginal(openXmlElement);
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
      value.Drawing = GetDrawing(openXmlElement);
      value.Control = GetControl(openXmlElement);
      value.ObjectEmbed = GetObjectEmbed(openXmlElement);
      value.ObjectLink = GetObjectLink(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.EmbeddedObject? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDxaOriginal(openXmlElement, value?.DxaOriginal);
      SetDyaOriginal(openXmlElement, value?.DyaOriginal);
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
      SetDrawing(openXmlElement, value?.Drawing);
      SetControl(openXmlElement, value?.Control);
      SetObjectEmbed(openXmlElement, value?.ObjectEmbed);
      SetObjectLink(openXmlElement, value?.ObjectLink);
      return openXmlElement;
    }
    return default;
  }
}
