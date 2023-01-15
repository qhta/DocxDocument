using DocumentModel.Math;
using OfficeMathArgumentType = DocumentFormat.OpenXml.Math.OfficeMathArgumentType;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Defines the OfficeMathArgumentType Class.
/// </summary>
public static class OfficeMathArgumentTypeConverter
{
  /// <summary>
  ///   Argument Properties.
  /// </summary>
  public static ArgumentProperties? GetArgumentProperties(OfficeMathArgumentType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
    if (itemElement != null)
      return ArgumentPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetArgumentProperties(OfficeMathArgumentType? openXmlElement, ArgumentProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArgumentPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ArgumentProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.OfficeMathArgumentType? CreateModelElement(OfficeMathArgumentType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.OfficeMathArgumentType();
      value.ArgumentProperties = GetArgumentProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.OfficeMathArgumentType? value)
    where OpenXmlElementType : OfficeMathArgumentType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetArgumentProperties(openXmlElement, value?.ArgumentProperties);
      return openXmlElement;
    }
    return default;
  }
}