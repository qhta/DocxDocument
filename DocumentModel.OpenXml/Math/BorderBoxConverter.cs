using DocumentModel.Math;
using BorderBox = DocumentFormat.OpenXml.Math.BorderBox;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Border-Box Function.
/// </summary>
public static class BorderBoxConverter
{
  /// <summary>
  ///   Border Box Properties.
  /// </summary>
  public static BorderBoxProperties? GetBorderBoxProperties(BorderBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBoxProperties>();
    if (itemElement != null)
      return BorderBoxPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBorderBoxProperties(BorderBox? openXmlElement, BorderBoxProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BorderBoxProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderBoxPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.BorderBoxProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(BorderBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(BorderBox? openXmlElement, Base? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.BorderBox? CreateModelElement(BorderBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.BorderBox();
      value.BorderBoxProperties = GetBorderBoxProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.BorderBox? value)
    where OpenXmlElementType : BorderBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBorderBoxProperties(openXmlElement, value?.BorderBoxProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}