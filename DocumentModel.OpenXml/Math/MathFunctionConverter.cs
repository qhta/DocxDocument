namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Function Apply Function.
/// </summary>
public static class MathFunctionConverter
{
  /// <summary>
  /// Function Properties.
  /// </summary>
  public static DocumentModel.Math.FunctionProperties? GetFunctionProperties(DocumentFormat.OpenXml.Math.MathFunction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.FunctionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFunctionProperties(DocumentFormat.OpenXml.Math.MathFunction? openXmlElement, DocumentModel.Math.FunctionProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.FunctionPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.FunctionProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Function Name.
  /// </summary>
  public static DocumentModel.Math.FunctionName? GetFunctionName(DocumentFormat.OpenXml.Math.MathFunction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionName>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.FunctionNameConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFunctionName(DocumentFormat.OpenXml.Math.MathFunction? openXmlElement, DocumentModel.Math.FunctionName? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FunctionName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.FunctionNameConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.FunctionName>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public static DocumentModel.Math.Base? GetBase(DocumentFormat.OpenXml.Math.MathFunction? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBase(DocumentFormat.OpenXml.Math.MathFunction? openXmlElement, DocumentModel.Math.Base? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.MathFunction? CreateModelElement(DocumentFormat.OpenXml.Math.MathFunction? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.MathFunction, new()
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
