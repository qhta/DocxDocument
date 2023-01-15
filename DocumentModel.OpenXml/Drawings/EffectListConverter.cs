using DocumentModel.Drawings;
using EffectList = DocumentFormat.OpenXml.Drawing.EffectList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Effect Container.
/// </summary>
public static class EffectListConverter
{
  /// <summary>
  ///   Blur Effect.
  /// </summary>
  public static Blur? GetBlur(EffectList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
    if (itemElement != null)
      return BlurConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlur(EffectList? openXmlElement, Blur? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Blur>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlurConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Blur>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FillOverlay.
  /// </summary>
  public static FillOverlay? GetFillOverlay(EffectList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
    if (itemElement != null)
      return FillOverlayConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillOverlay(EffectList? openXmlElement, FillOverlay? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillOverlayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillOverlay>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Glow.
  /// </summary>
  public static Glow? GetGlow(EffectList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
    if (itemElement != null)
      return GlowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGlow(EffectList? openXmlElement, Glow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Glow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GlowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Glow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   InnerShadow.
  /// </summary>
  public static InnerShadow? GetInnerShadow(EffectList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
    if (itemElement != null)
      return InnerShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetInnerShadow(EffectList? openXmlElement, InnerShadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.InnerShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InnerShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.InnerShadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OuterShadow.
  /// </summary>
  public static OuterShadow? GetOuterShadow(EffectList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
    if (itemElement != null)
      return OuterShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOuterShadow(EffectList? openXmlElement, OuterShadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.OuterShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OuterShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.OuterShadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PresetShadow.
  /// </summary>
  public static PresetShadow? GetPresetShadow(EffectList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
    if (itemElement != null)
      return PresetShadowConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetShadow(EffectList? openXmlElement, PresetShadow? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetShadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetShadowConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetShadow>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Reflection.
  /// </summary>
  public static Reflection? GetReflection(EffectList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
    if (itemElement != null)
      return ReflectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetReflection(EffectList? openXmlElement, Reflection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Reflection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ReflectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Reflection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SoftEdge.
  /// </summary>
  public static SoftEdge? GetSoftEdge(EffectList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
    if (itemElement != null)
      return SoftEdgeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSoftEdge(EffectList? openXmlElement, SoftEdge? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SoftEdge>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SoftEdgeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SoftEdge>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.EffectList? CreateModelElement(EffectList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectList();
      value.Blur = GetBlur(openXmlElement);
      value.FillOverlay = GetFillOverlay(openXmlElement);
      value.Glow = GetGlow(openXmlElement);
      value.InnerShadow = GetInnerShadow(openXmlElement);
      value.OuterShadow = GetOuterShadow(openXmlElement);
      value.PresetShadow = GetPresetShadow(openXmlElement);
      value.Reflection = GetReflection(openXmlElement);
      value.SoftEdge = GetSoftEdge(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectList? value)
    where OpenXmlElementType : EffectList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBlur(openXmlElement, value?.Blur);
      SetFillOverlay(openXmlElement, value?.FillOverlay);
      SetGlow(openXmlElement, value?.Glow);
      SetInnerShadow(openXmlElement, value?.InnerShadow);
      SetOuterShadow(openXmlElement, value?.OuterShadow);
      SetPresetShadow(openXmlElement, value?.PresetShadow);
      SetReflection(openXmlElement, value?.Reflection);
      SetSoftEdge(openXmlElement, value?.SoftEdge);
      return openXmlElement;
    }
    return default;
  }
}