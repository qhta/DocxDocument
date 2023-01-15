using DocumentModel.Math;
using Phantom = DocumentFormat.OpenXml.Math.Phantom;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Phantom Function.
/// </summary>
public static class PhantomConverter
{
  /// <summary>
  ///   Phantom Properties.
  /// </summary>
  public static PhantomProperties? GetPhantomProperties(Phantom? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.PhantomProperties>();
    if (itemElement != null)
      return PhantomPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPhantomProperties(Phantom? openXmlElement, PhantomProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.PhantomProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PhantomPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.PhantomProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Base.
  /// </summary>
  public static Base? GetBase(Phantom? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Base>();
    if (itemElement != null)
      return BaseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBase(Phantom? openXmlElement, Base? value)
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

  public static DocumentModel.Math.Phantom? CreateModelElement(Phantom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Phantom();
      value.PhantomProperties = GetPhantomProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Phantom? value)
    where OpenXmlElementType : Phantom, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPhantomProperties(openXmlElement, value?.PhantomProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}