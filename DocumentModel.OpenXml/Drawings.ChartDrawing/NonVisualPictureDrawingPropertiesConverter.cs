using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public static class NonVisualPictureDrawingPropertiesConverter
{
  /// <summary>
  ///   preferRelativeResize
  /// </summary>
  public static Boolean? GetPreferRelativeResize(NonVisualPictureDrawingProperties? openXmlElement)
  {
    return openXmlElement?.PreferRelativeResize?.Value;
  }

  public static void SetPreferRelativeResize(NonVisualPictureDrawingProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.PreferRelativeResize = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.PreferRelativeResize = null;
  }

  /// <summary>
  ///   PictureLocks.
  /// </summary>
  public static PictureLocks? GetPictureLocks(NonVisualPictureDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
    if (itemElement != null)
      return PictureLocksConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPictureLocks(NonVisualPictureDrawingProperties? openXmlElement, PictureLocks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PictureLocks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public static NonVisualPicturePropertiesExtensionList? GetNonVisualPicturePropertiesExtensionList(NonVisualPictureDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
    if (itemElement != null)
      return NonVisualPicturePropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualPicturePropertiesExtensionList(NonVisualPictureDrawingProperties? openXmlElement, NonVisualPicturePropertiesExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualPicturePropertiesExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.NonVisualPictureDrawingProperties? CreateModelElement(NonVisualPictureDrawingProperties? openXmlElement)
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
    where OpenXmlElementType : NonVisualPictureDrawingProperties, new()
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