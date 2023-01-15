using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Drawing.Diagram;
using DocumentModel.Drawings.Office;
using DocumentModel.OpenXml.Drawings.Office;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the DataModelExtension Class.
/// </summary>
public static class DataModelExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(DataModelExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(DataModelExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static DataModelExtensionBlock? GetDataModelExtensionBlock(DataModelExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>();
    if (itemElement != null)
      return DataModelExtensionBlockConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataModelExtensionBlock(DataModelExtension? openXmlElement, DataModelExtensionBlock? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataModelExtensionBlockConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetRecolorImages(DataModelExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RecolorImages>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRecolorImages(DataModelExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RecolorImages>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RecolorImages();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.DataModelExtension? CreateModelElement(DataModelExtension? openXmlElement)
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
    where OpenXmlElementType : DataModelExtension, new()
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