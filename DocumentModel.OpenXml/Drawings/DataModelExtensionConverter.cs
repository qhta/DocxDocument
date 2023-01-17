namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public static class DataModelExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.DataModelExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.DataModelExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Office.DataModelExtensionBlock? GetDataModelExtensionBlock(DocumentFormat.OpenXml.Drawing.DataModelExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.DataModelExtensionBlockConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataModelExtensionBlock(DocumentFormat.OpenXml.Drawing.DataModelExtension openXmlElement, DocumentModel.Drawings.Office.DataModelExtensionBlock? value)
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
  
  private static Boolean? GetRecolorImages(DocumentFormat.OpenXml.Drawing.DataModelExtension openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.RecolorImages>();
    return itemElement != null;
  }
  
  private static void SetRecolorImages(DocumentFormat.OpenXml.Drawing.DataModelExtension openXmlElement, Boolean? value)
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
      SetDataModelExtensionBlock(openXmlElement, value?.DataModelExtensionBlock);
      SetRecolorImages(openXmlElement, value?.RecolorImages);
      return openXmlElement;
    }
    return default;
  }
}
