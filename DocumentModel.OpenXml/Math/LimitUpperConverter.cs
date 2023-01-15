using DocumentModel.Math;
using LimitUpper = DocumentFormat.OpenXml.Math.LimitUpper;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Upper-Limit Function.
/// </summary>
public static class LimitUpperConverter
{
  /// <summary>
  ///   Upper Limit Properties.
  /// </summary>
  public static LimitUpperProperties? GetLimitUpperProperties(LimitUpper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpperProperties>();
    if (itemElement != null)
      return LimitUpperPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimitUpperProperties(LimitUpper? openXmlElement, LimitUpperProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitUpperProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitUpperPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitUpperProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(LimitUpper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(LimitUpper? openXmlElement, Base? value)
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

  /// <summary>
  ///   Limit (Upper).
  /// </summary>
  public static Limit? GetLimit(LimitUpper? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
    if (itemElement != null)
      return LimitConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimit(LimitUpper? openXmlElement, Limit? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Limit>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.LimitUpper? CreateModelElement(LimitUpper? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.LimitUpper();
      value.LimitUpperProperties = GetLimitUpperProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.LimitUpper? value)
    where OpenXmlElementType : LimitUpper, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimitUpperProperties(openXmlElement, value?.LimitUpperProperties);
      SetBase(openXmlElement, value?.Base);
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}