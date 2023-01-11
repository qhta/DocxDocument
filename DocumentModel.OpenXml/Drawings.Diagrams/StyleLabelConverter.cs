namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public static class StyleLabelConverter
{
  /// <summary>
  /// Style Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.Scene3D? GetScene3D(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScene3D(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.Scene3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.Scene3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.Shape3D? GetShape3D(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.Shape3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape3D(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.Shape3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.Shape3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.Style? GetStyle(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.StyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.Style? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Style>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Diagrams.StyleLabel? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleLabel();
      value.Name = GetName(openXmlElement);
      value.Scene3D = GetScene3D(openXmlElement);
      value.Shape3D = GetShape3D(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleLabel? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
