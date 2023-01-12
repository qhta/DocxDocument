namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public static class AdjustHandleListConverter
{
  public static DocumentModel.Drawings.AdjustHandleXY? GetAdjustHandleXY(DocumentFormat.OpenXml.Drawing.AdjustHandleList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustHandleXYConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAdjustHandleXY(DocumentFormat.OpenXml.Drawing.AdjustHandleList? openXmlElement, DocumentModel.Drawings.AdjustHandleXY? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AdjustHandleXYConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.AdjustHandlePolar? GetAdjustHandlePolar(DocumentFormat.OpenXml.Drawing.AdjustHandleList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandlePolar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.AdjustHandlePolarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAdjustHandlePolar(DocumentFormat.OpenXml.Drawing.AdjustHandleList? openXmlElement, DocumentModel.Drawings.AdjustHandlePolar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandlePolar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.AdjustHandlePolarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.AdjustHandlePolar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.AdjustHandleList? CreateModelElement(DocumentFormat.OpenXml.Drawing.AdjustHandleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustHandleList();
      value.AdjustHandleXY = GetAdjustHandleXY(openXmlElement);
      value.AdjustHandlePolar = GetAdjustHandlePolar(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AdjustHandleList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AdjustHandleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
