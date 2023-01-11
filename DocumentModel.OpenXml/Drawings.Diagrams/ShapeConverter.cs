namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Shape.
/// </summary>
public static class ShapeConverter
{
  /// <summary>
  /// Rotation
  /// </summary>
  public static Double? GetRotation(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    return openXmlElement?.Rotation?.Value;
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Rotation = value;
  }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  public static String? GetType(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Type = new StringValue { Value = value };
      else
        openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  public static String? GetBlip(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    return openXmlElement?.Blip?.Value;
  }
  
  public static void SetBlip(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Blip = new StringValue { Value = value };
      else
        openXmlElement.Blip = null;
  }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  public static Int32? GetZOrderOffset(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    return openXmlElement?.ZOrderOffset?.Value;
  }
  
  public static void SetZOrderOffset(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ZOrderOffset = value;
  }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  public static Boolean? GetHideGeometry(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    return openXmlElement?.HideGeometry?.Value;
  }
  
  public static void SetHideGeometry(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HideGeometry = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.HideGeometry = null;
  }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  public static Boolean? GetLockedText(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    return openXmlElement?.LockedText?.Value;
  }
  
  public static void SetLockedText(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LockedText = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.LockedText = null;
  }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  public static Boolean? GetBlipPlaceholder(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    return openXmlElement?.BlipPlaceholder?.Value;
  }
  
  public static void SetBlipPlaceholder(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.BlipPlaceholder = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.BlipPlaceholder = null;
  }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.AdjustList? GetAdjustList(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.AdjustListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAdjustList(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, DocumentModel.Drawings.Diagrams.AdjustList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.AdjustListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.Shape? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.Shape? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.Shape();
      value.Rotation = GetRotation(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.Blip = GetBlip(openXmlElement);
      value.ZOrderOffset = GetZOrderOffset(openXmlElement);
      value.HideGeometry = GetHideGeometry(openXmlElement);
      value.LockedText = GetLockedText(openXmlElement);
      value.BlipPlaceholder = GetBlipPlaceholder(openXmlElement);
      value.AdjustList = GetAdjustList(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.Shape? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.Shape, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
