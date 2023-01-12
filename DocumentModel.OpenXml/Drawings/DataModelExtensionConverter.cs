namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public static class DataModelExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.DataModelExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.DataModelExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Office.DataModelExtensionBlock? GetDataModelExtensionBlock(DocumentFormat.OpenXml.Drawing.DataModelExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.DataModelExtensionBlockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataModelExtensionBlock(DocumentFormat.OpenXml.Drawing.DataModelExtension? openXmlElement, DocumentModel.Drawings.Office.DataModelExtensionBlock? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.DataModelExtensionBlockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetRecolorImages(DocumentFormat.OpenXml.Drawing.DataModelExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.RecolorImages>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRecolorImages(DocumentFormat.OpenXml.Drawing.DataModelExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.RecolorImages>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Diagram.RecolorImages();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.DataModelExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.DataModelExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.DataModelExtension();
      value.Uri = GetUri(openXmlElement);
      value.DataModelExtensionBlock = GetDataModelExtensionBlock(openXmlElement);
      value.RecolorImages = GetRecolorImages(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.DataModelExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.DataModelExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
