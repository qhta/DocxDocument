namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public static class NonVisualPictureDrawingPropertiesConverter
{
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  private static Boolean? GetPreferRelativeResize(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties openXmlElement)
  {
    return openXmlElement?.PreferRelativeResize?.Value;
  }
  
  private static void SetPreferRelativeResize(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PreferRelativeResize = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.PreferRelativeResize = null;
  }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  private static DocumentModel.Drawings.PictureLocks? GetPictureLocks(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PictureLocksConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPictureLocks(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties openXmlElement, DocumentModel.Drawings.PictureLocks? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.PictureLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PictureLocks>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  private static DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? GetNonVisualPicturePropertiesExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.NonVisualPicturePropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualPicturePropertiesExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties openXmlElement, DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.NonVisualPicturePropertiesExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualPictureDrawingProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualPictureDrawingProperties();
      value.PreferRelativeResize = GetPreferRelativeResize(openXmlElement);
      value.PictureLocks = GetPictureLocks(openXmlElement);
      value.NonVisualPicturePropertiesExtensionList = GetNonVisualPicturePropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualPictureDrawingProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreferRelativeResize(openXmlElement, value?.PreferRelativeResize);
      SetPictureLocks(openXmlElement, value?.PictureLocks);
      SetNonVisualPicturePropertiesExtensionList(openXmlElement, value?.NonVisualPicturePropertiesExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
