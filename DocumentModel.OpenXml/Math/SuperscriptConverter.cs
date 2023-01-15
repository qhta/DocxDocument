using DocumentModel.Math;
using Superscript = DocumentFormat.OpenXml.Math.Superscript;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Superscript Function.
/// </summary>
public static class SuperscriptConverter
{
  /// <summary>
  ///   Superscript Properties.
  /// </summary>
  public static SuperscriptProperties? GetSuperscriptProperties(Superscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperscriptProperties>();
    if (itemElement != null)
      return SuperscriptPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSuperscriptProperties(Superscript? openXmlElement, SuperscriptProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperscriptProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuperscriptPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SuperscriptProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(Superscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(Superscript? openXmlElement, Base? value)
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
  ///   Superscript (Superscript function).
  /// </summary>
  public static SuperArgument? GetSuperArgument(Superscript? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
    if (itemElement != null)
      return SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSuperArgument(Superscript? openXmlElement, SuperArgument? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.SuperArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuperArgumentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.SuperArgument>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.Superscript? CreateModelElement(Superscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Superscript();
      value.SuperscriptProperties = GetSuperscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Superscript? value)
    where OpenXmlElementType : Superscript, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSuperscriptProperties(openXmlElement, value?.SuperscriptProperties);
      SetBase(openXmlElement, value?.Base);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      return openXmlElement;
    }
    return default;
  }
}