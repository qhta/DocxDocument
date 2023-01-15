using DocumentFormat.OpenXml.Office2010.Word;
using GradientFillProperties = DocumentModel.Wordprocessing.GradientFillProperties;
using SolidColorFillProperties = DocumentModel.Wordprocessing.SolidColorFillProperties;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the FillTextEffect Class.
/// </summary>
public static class FillTextEffectConverter
{
  /// <summary>
  ///   NoFillEmpty.
  /// </summary>
  public static Boolean? GetNoFillEmpty(FillTextEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoFillEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoFillEmpty(FillTextEffect? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoFillEmpty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoFillEmpty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SolidColorFillProperties.
  /// </summary>
  public static SolidColorFillProperties? GetSolidColorFillProperties(FillTextEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
    if (itemElement != null)
      return SolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSolidColorFillProperties(FillTextEffect? openXmlElement, SolidColorFillProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   GradientFillProperties.
  /// </summary>
  public static GradientFillProperties? GetGradientFillProperties(FillTextEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
    if (itemElement != null)
      return GradientFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientFillProperties(FillTextEffect? openXmlElement, GradientFillProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.FillTextEffect? CreateModelElement(FillTextEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FillTextEffect();
      value.NoFillEmpty = GetNoFillEmpty(openXmlElement);
      value.SolidColorFillProperties = GetSolidColorFillProperties(openXmlElement);
      value.GradientFillProperties = GetGradientFillProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FillTextEffect? value)
    where OpenXmlElementType : FillTextEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoFillEmpty(openXmlElement, value?.NoFillEmpty);
      SetSolidColorFillProperties(openXmlElement, value?.SolidColorFillProperties);
      SetGradientFillProperties(openXmlElement, value?.GradientFillProperties);
      return openXmlElement;
    }
    return default;
  }
}