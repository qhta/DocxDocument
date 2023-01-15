using DocumentModel.Math;
using Radical = DocumentFormat.OpenXml.Math.Radical;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Radical Function.
/// </summary>
public static class RadicalConverter
{
  /// <summary>
  ///   Radical Properties.
  /// </summary>
  public static RadicalProperties? GetRadicalProperties(Radical? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.RadicalProperties>();
    if (itemElement != null)
      return RadicalPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadicalProperties(Radical? openXmlElement, RadicalProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.RadicalProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadicalPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.RadicalProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Degree.
  /// </summary>
  public static Degree? GetDegree(Radical? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Degree>();
    if (itemElement != null)
      return DegreeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDegree(Radical? openXmlElement, Degree? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Degree>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DegreeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Degree>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(Radical? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(Radical? openXmlElement, Base? value)
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

  public static DocumentModel.Math.Radical? CreateModelElement(Radical? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Radical();
      value.RadicalProperties = GetRadicalProperties(openXmlElement);
      value.Degree = GetDegree(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Radical? value)
    where OpenXmlElementType : Radical, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadicalProperties(openXmlElement, value?.RadicalProperties);
      SetDegree(openXmlElement, value?.Degree);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}