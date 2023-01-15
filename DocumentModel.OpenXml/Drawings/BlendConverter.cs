using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using Blend = DocumentFormat.OpenXml.Drawing.Blend;
using EffectContainer = DocumentModel.Drawings.EffectContainer;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Blend Effect.
/// </summary>
public static class BlendConverter
{
  /// <summary>
  ///   Blend Mode
  /// </summary>
  public static BlendMode? GetBlendMode(Blend? openXmlElement)
  {
    return EnumValueConverter.GetValue<BlendModeValues, BlendMode>(openXmlElement?.BlendMode?.Value);
  }

  public static void SetBlendMode(Blend? openXmlElement, BlendMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.BlendMode = EnumValueConverter.CreateEnumValue<BlendModeValues, BlendMode>(value);
  }

  /// <summary>
  ///   Effect to blend.
  /// </summary>
  public static EffectContainer? GetEffectContainer(Blend? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
    if (itemElement != null)
      return EffectContainerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectContainer(Blend? openXmlElement, EffectContainer? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectContainer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectContainerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectContainer>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Blend? CreateModelElement(Blend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Blend();
      value.BlendMode = GetBlendMode(openXmlElement);
      value.EffectContainer = GetEffectContainer(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Blend? value)
    where OpenXmlElementType : Blend, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlendMode(openXmlElement, value?.BlendMode);
      SetEffectContainer(openXmlElement, value?.EffectContainer);
      return openXmlElement;
    }
    return default;
  }
}