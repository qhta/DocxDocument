using DocumentModel.Math;
using LimitLower = DocumentFormat.OpenXml.Math.LimitLower;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Lower-Limit Function.
/// </summary>
public static class LimitLowerConverter
{
  /// <summary>
  ///   Lower Limit Properties.
  /// </summary>
  public static LimitLowerProperties? GetLimitLowerProperties(LimitLower? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLowerProperties>();
    if (itemElement != null)
      return LimitLowerPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimitLowerProperties(LimitLower? openXmlElement, LimitLowerProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.LimitLowerProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LimitLowerPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.LimitLowerProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(LimitLower? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(LimitLower? openXmlElement, Base? value)
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
  ///   Limit (Lower).
  /// </summary>
  public static Limit? GetLimit(LimitLower? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Limit>();
    if (itemElement != null)
      return LimitConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLimit(LimitLower? openXmlElement, Limit? value)
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

  public static DocumentModel.Math.LimitLower? CreateModelElement(LimitLower? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.LimitLower();
      value.LimitLowerProperties = GetLimitLowerProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.LimitLower? value)
    where OpenXmlElementType : LimitLower, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimitLowerProperties(openXmlElement, value?.LimitLowerProperties);
      SetBase(openXmlElement, value?.Base);
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}