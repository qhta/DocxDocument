using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using GradientFillProperties = DocumentModel.Wordprocessing.GradientFillProperties;
using LineJoinMiterProperties = DocumentModel.Wordprocessing.LineJoinMiterProperties;
using SolidColorFillProperties = DocumentModel.Wordprocessing.SolidColorFillProperties;
using TextOutlineEffect = DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the TextOutlineEffect Class.
/// </summary>
public static class TextOutlineEffectConverter
{
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetLineWidth(TextOutlineEffect? openXmlElement)
  {
    return openXmlElement?.LineWidth?.Value;
  }

  public static void SetLineWidth(TextOutlineEffect? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LineWidth = value;
  }

  /// <summary>
  ///   cap, this property is only available in Office 2010 and later.
  /// </summary>
  public static LineCapKind? GetCapType(TextOutlineEffect? openXmlElement)
  {
    return EnumValueConverter.GetValue<LineCapValues, LineCapKind>(openXmlElement?.CapType?.Value);
  }

  public static void SetCapType(TextOutlineEffect? openXmlElement, LineCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CapType = EnumValueConverter.CreateEnumValue<LineCapValues, LineCapKind>(value);
  }

  /// <summary>
  ///   cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  public static CompoundLineKind? GetCompound(TextOutlineEffect? openXmlElement)
  {
    return EnumValueConverter.GetValue<CompoundLineValues, CompoundLineKind>(openXmlElement?.Compound?.Value);
  }

  public static void SetCompound(TextOutlineEffect? openXmlElement, CompoundLineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Compound = EnumValueConverter.CreateEnumValue<CompoundLineValues, CompoundLineKind>(value);
  }

  /// <summary>
  ///   algn, this property is only available in Office 2010 and later.
  /// </summary>
  public static PenAlignmentKind? GetAlignment(TextOutlineEffect? openXmlElement)
  {
    return EnumValueConverter.GetValue<PenAlignmentValues, PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(TextOutlineEffect? openXmlElement, PenAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<PenAlignmentValues, PenAlignmentKind>(value);
  }

  public static Boolean? GetNoFillEmpty(TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoFillEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoFillEmpty(TextOutlineEffect? openXmlElement, Boolean? value)
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

  public static SolidColorFillProperties? GetSolidColorFillProperties(TextOutlineEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
    if (itemElement != null)
      return SolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSolidColorFillProperties(TextOutlineEffect? openXmlElement, SolidColorFillProperties? value)
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

  public static GradientFillProperties? GetGradientFillProperties(TextOutlineEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
    if (itemElement != null)
      return GradientFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientFillProperties(TextOutlineEffect? openXmlElement, GradientFillProperties? value)
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

  public static PresetLineDashKind? GetPresetLineDashProperties(TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PresetLineDashProperties>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<PresetLineDashValues, PresetLineDashKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPresetLineDashProperties(TextOutlineEffect? openXmlElement, PresetLineDashKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PresetLineDashProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<PresetLineDashProperties, PresetLineDashValues, PresetLineDashKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetRoundEmpty(TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RoundEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRoundEmpty(TextOutlineEffect? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<RoundEmpty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new RoundEmpty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBevelEmpty(TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BevelEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBevelEmpty(TextOutlineEffect? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BevelEmpty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BevelEmpty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LineJoinMiterProperties? GetLineJoinMiterProperties(TextOutlineEffect? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties>();
    if (itemElement != null)
      return LineJoinMiterPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineJoinMiterProperties(TextOutlineEffect? openXmlElement, LineJoinMiterProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineJoinMiterPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TextOutlineEffect? CreateModelElement(TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TextOutlineEffect();
      value.LineWidth = GetLineWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.Compound = GetCompound(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.NoFillEmpty = GetNoFillEmpty(openXmlElement);
      value.SolidColorFillProperties = GetSolidColorFillProperties(openXmlElement);
      value.GradientFillProperties = GetGradientFillProperties(openXmlElement);
      value.PresetLineDashProperties = GetPresetLineDashProperties(openXmlElement);
      value.RoundEmpty = GetRoundEmpty(openXmlElement);
      value.BevelEmpty = GetBevelEmpty(openXmlElement);
      value.LineJoinMiterProperties = GetLineJoinMiterProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TextOutlineEffect? value)
    where OpenXmlElementType : TextOutlineEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineWidth(openXmlElement, value?.LineWidth);
      SetCapType(openXmlElement, value?.CapType);
      SetCompound(openXmlElement, value?.Compound);
      SetAlignment(openXmlElement, value?.Alignment);
      SetNoFillEmpty(openXmlElement, value?.NoFillEmpty);
      SetSolidColorFillProperties(openXmlElement, value?.SolidColorFillProperties);
      SetGradientFillProperties(openXmlElement, value?.GradientFillProperties);
      SetPresetLineDashProperties(openXmlElement, value?.PresetLineDashProperties);
      SetRoundEmpty(openXmlElement, value?.RoundEmpty);
      SetBevelEmpty(openXmlElement, value?.BevelEmpty);
      SetLineJoinMiterProperties(openXmlElement, value?.LineJoinMiterProperties);
      return openXmlElement;
    }
    return default;
  }
}