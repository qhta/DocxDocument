using DocumentModel.Wordprocessing;
using GradientFillProperties = DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the GradientFillProperties Class.
/// </summary>
public static class GradientFillPropertiesConverter
{
  /// <summary>
  ///   GradientStopList.
  /// </summary>
  public static GradientStopList? GetGradientStopList(GradientFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientStopList>();
    if (itemElement != null)
      return GradientStopListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientStopList(GradientFillProperties? openXmlElement, GradientStopList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientStopList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientStopListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.GradientStopList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LinearShadeProperties? GetLinearShadeProperties(GradientFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>();
    if (itemElement != null)
      return LinearShadePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLinearShadeProperties(GradientFillProperties? openXmlElement, LinearShadeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinearShadePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PathShadeProperties? GetPathShadeProperties(GradientFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>();
    if (itemElement != null)
      return PathShadePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPathShadeProperties(GradientFillProperties? openXmlElement, PathShadeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PathShadePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.PathShadeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.GradientFillProperties? CreateModelElement(GradientFillProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.GradientFillProperties();
      value.GradientStopList = GetGradientStopList(openXmlElement);
      value.LinearShadeProperties = GetLinearShadeProperties(openXmlElement);
      value.PathShadeProperties = GetPathShadeProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.GradientFillProperties? value)
    where OpenXmlElementType : GradientFillProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGradientStopList(openXmlElement, value?.GradientStopList);
      SetLinearShadeProperties(openXmlElement, value?.LinearShadeProperties);
      SetPathShadeProperties(openXmlElement, value?.PathShadeProperties);
      return openXmlElement;
    }
    return default;
  }
}