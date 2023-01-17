namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
public static class ObjectDefaultsConverter
{
  /// <summary>
  /// Shape Default.
  /// </summary>
  private static DocumentModel.Drawings.ShapeDefault? GetShapeDefault(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeDefault>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ShapeDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeDefault(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement, DocumentModel.Drawings.ShapeDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ShapeDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  private static DocumentModel.Drawings.LineDefault? GetLineDefault(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineDefault>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineDefault(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement, DocumentModel.Drawings.LineDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.LineDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  private static DocumentModel.Drawings.TextDefault? GetTextDefault(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextDefault>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.TextDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextDefault(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement, DocumentModel.Drawings.TextDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.TextDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TextDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ObjectDefaults? CreateModelElement(DocumentFormat.OpenXml.Drawing.ObjectDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ObjectDefaults();
      value.ShapeDefault = GetShapeDefault(openXmlElement);
      value.LineDefault = GetLineDefault(openXmlElement);
      value.TextDefault = GetTextDefault(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ObjectDefaults? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ObjectDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeDefault(openXmlElement, value?.ShapeDefault);
      SetLineDefault(openXmlElement, value?.LineDefault);
      SetTextDefault(openXmlElement, value?.TextDefault);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
