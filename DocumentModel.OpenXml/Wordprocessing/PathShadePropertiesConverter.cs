using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using FillToRectangle = DocumentModel.Wordprocessing.FillToRectangle;
using PathShadeProperties = DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the PathShadeProperties Class.
/// </summary>
public static class PathShadePropertiesConverter
{
  /// <summary>
  ///   path, this property is only available in Office 2010 and later.
  /// </summary>
  public static PathShadeKind? GetPath(PathShadeProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<PathShadeTypeValues, PathShadeKind>(openXmlElement?.Path?.Value);
  }

  public static void SetPath(PathShadeProperties? openXmlElement, PathShadeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Path = EnumValueConverter.CreateEnumValue<PathShadeTypeValues, PathShadeKind>(value);
  }

  /// <summary>
  ///   FillToRectangle.
  /// </summary>
  public static FillToRectangle? GetFillToRectangle(PathShadeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillToRectangle>();
    if (itemElement != null)
      return FillToRectangleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillToRectangle(PathShadeProperties? openXmlElement, FillToRectangle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.FillToRectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillToRectangleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.FillToRectangle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.PathShadeProperties? CreateModelElement(PathShadeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PathShadeProperties();
      value.Path = GetPath(openXmlElement);
      value.FillToRectangle = GetFillToRectangle(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PathShadeProperties? value)
    where OpenXmlElementType : PathShadeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPath(openXmlElement, value?.Path);
      SetFillToRectangle(openXmlElement, value?.FillToRectangle);
      return openXmlElement;
    }
    return default;
  }
}