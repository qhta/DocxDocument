using DocumentModel.Math;
using MathFunction = DocumentFormat.OpenXml.Math.MathFunction;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Function Apply Function.
/// </summary>
public static class MathFunctionConverter
{
  /// <summary>
  ///   Function Properties.
  /// </summary>
  public static FunctionProperties? GetFunctionProperties(MathFunction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionProperties>();
    if (itemElement != null)
      return FunctionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFunctionProperties(MathFunction? openXmlElement, FunctionProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FunctionPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.FunctionProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Function Name.
  /// </summary>
  public static FunctionName? GetFunctionName(MathFunction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionName>();
    if (itemElement != null)
      return FunctionNameConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFunctionName(MathFunction? openXmlElement, FunctionName? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FunctionNameConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.FunctionName>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base (Argument).
  /// </summary>
  public static Base? GetBase(MathFunction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(MathFunction? openXmlElement, Base? value)
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

  public static DocumentModel.Math.MathFunction? CreateModelElement(MathFunction? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.MathFunction();
      value.FunctionProperties = GetFunctionProperties(openXmlElement);
      value.FunctionName = GetFunctionName(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.MathFunction? value)
    where OpenXmlElementType : MathFunction, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFunctionProperties(openXmlElement, value?.FunctionProperties);
      SetFunctionName(openXmlElement, value?.FunctionName);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}