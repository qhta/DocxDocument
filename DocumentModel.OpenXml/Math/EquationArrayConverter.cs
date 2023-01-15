using DocumentModel.Math;
using EquationArray = DocumentFormat.OpenXml.Math.EquationArray;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Equation-Array Function.
/// </summary>
public static class EquationArrayConverter
{
  /// <summary>
  ///   Equation Array Properties.
  /// </summary>
  public static EquationArrayProperties? GetEquationArrayProperties(EquationArray? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArrayProperties>();
    if (itemElement != null)
      return EquationArrayPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEquationArrayProperties(EquationArray? openXmlElement, EquationArrayProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.EquationArrayProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EquationArrayPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.EquationArrayProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<Base>? GetBases(EquationArray? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Base>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Math.Base>())
      {
        var newItem = BaseConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetBases(EquationArray? openXmlElement, Collection<Base>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.Base>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BaseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Base>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Math.EquationArray? CreateModelElement(EquationArray? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.EquationArray();
      value.EquationArrayProperties = GetEquationArrayProperties(openXmlElement);
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.EquationArray? value)
    where OpenXmlElementType : EquationArray, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEquationArrayProperties(openXmlElement, value?.EquationArrayProperties);
      SetBases(openXmlElement, value?.Bases);
      return openXmlElement;
    }
    return default;
  }
}