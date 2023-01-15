using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using CustomDash = DocumentModel.Drawings.CustomDash;
using GradientFill = DocumentModel.Drawings.GradientFill;
using HiddenLineProperties = DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties;
using LineEndPropertiesType = DocumentModel.Drawings.LineEndPropertiesType;
using LinePropertiesExtensionList = DocumentModel.Drawings.LinePropertiesExtensionList;
using Miter = DocumentModel.Drawings.Miter;
using PatternFill = DocumentModel.Drawings.PatternFill;
using SolidFill = DocumentModel.Drawings.SolidFill;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the HiddenLineProperties Class.
/// </summary>
public static class HiddenLinePropertiesConverter
{
  /// <summary>
  ///   line width
  /// </summary>
  public static Int32? GetWidth(HiddenLineProperties? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(HiddenLineProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   line cap
  /// </summary>
  public static LineCapKind? GetCapType(HiddenLineProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<LineCapValues, LineCapKind>(openXmlElement?.CapType?.Value);
  }

  public static void SetCapType(HiddenLineProperties? openXmlElement, LineCapKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CapType = EnumValueConverter.CreateEnumValue<LineCapValues, LineCapKind>(value);
  }

  /// <summary>
  ///   compound line type
  /// </summary>
  public static CompoundLineKind? GetCompoundLineType(HiddenLineProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<CompoundLineValues, CompoundLineKind>(openXmlElement?.CompoundLineType?.Value);
  }

  public static void SetCompoundLineType(HiddenLineProperties? openXmlElement, CompoundLineKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.CompoundLineType = EnumValueConverter.CreateEnumValue<CompoundLineValues, CompoundLineKind>(value);
  }

  /// <summary>
  ///   pen alignment
  /// </summary>
  public static PenAlignmentKind? GetAlignment(HiddenLineProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<PenAlignmentValues, PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }

  public static void SetAlignment(HiddenLineProperties? openXmlElement, PenAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<PenAlignmentValues, PenAlignmentKind>(value);
  }

  public static Boolean? GetNoFill(HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoFill>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoFill(HiddenLineProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SolidFill? GetSolidFill(HiddenLineProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSolidFill(HiddenLineProperties? openXmlElement, SolidFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SolidFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SolidFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GradientFill? GetGradientFill(HiddenLineProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientFill(HiddenLineProperties? openXmlElement, GradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PatternFill? GetPatternFill(HiddenLineProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPatternFill(HiddenLineProperties? openXmlElement, PatternFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PatternFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PatternFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PresetLineDashKind? GetPresetDash(HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PresetDash>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<PresetLineDashValues, PresetLineDashKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPresetDash(HiddenLineProperties? openXmlElement, PresetLineDashKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PresetDash>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<PresetDash, PresetLineDashValues, PresetLineDashKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CustomDash? GetCustomDash(HiddenLineProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
    if (itemElement != null)
      return CustomDashConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomDash(HiddenLineProperties? openXmlElement, CustomDash? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomDashConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomDash>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetRound(HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Round>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRound(HiddenLineProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Round>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Round();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetLineJoinBevel(HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineJoinBevel>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLineJoinBevel(HiddenLineProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<LineJoinBevel>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new LineJoinBevel();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Miter? GetMiter(HiddenLineProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Miter>();
    if (itemElement != null)
      return MiterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMiter(HiddenLineProperties? openXmlElement, Miter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Miter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MiterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Miter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LineEndPropertiesType? GetHeadEnd(HiddenLineProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HeadEnd>();
    if (itemElement != null)
      return LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHeadEnd(HiddenLineProperties? openXmlElement, LineEndPropertiesType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HeadEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineEndPropertiesTypeConverter.CreateOpenXmlElement<HeadEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LineEndPropertiesType? GetTailEnd(HiddenLineProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TailEnd>();
    if (itemElement != null)
      return LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTailEnd(HiddenLineProperties? openXmlElement, LineEndPropertiesType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TailEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineEndPropertiesTypeConverter.CreateOpenXmlElement<TailEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LinePropertiesExtensionList? GetLinePropertiesExtensionList(HiddenLineProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>();
    if (itemElement != null)
      return LinePropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLinePropertiesExtensionList(HiddenLineProperties? openXmlElement, LinePropertiesExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinePropertiesExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.HiddenLineProperties? CreateModelElement(HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HiddenLineProperties();
      value.Width = GetWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.CompoundLineType = GetCompoundLineType(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.PresetDash = GetPresetDash(openXmlElement);
      value.CustomDash = GetCustomDash(openXmlElement);
      value.Round = GetRound(openXmlElement);
      value.LineJoinBevel = GetLineJoinBevel(openXmlElement);
      value.Miter = GetMiter(openXmlElement);
      value.HeadEnd = GetHeadEnd(openXmlElement);
      value.TailEnd = GetTailEnd(openXmlElement);
      value.LinePropertiesExtensionList = GetLinePropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HiddenLineProperties? value)
    where OpenXmlElementType : HiddenLineProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetCapType(openXmlElement, value?.CapType);
      SetCompoundLineType(openXmlElement, value?.CompoundLineType);
      SetAlignment(openXmlElement, value?.Alignment);
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetPresetDash(openXmlElement, value?.PresetDash);
      SetCustomDash(openXmlElement, value?.CustomDash);
      SetRound(openXmlElement, value?.Round);
      SetLineJoinBevel(openXmlElement, value?.LineJoinBevel);
      SetMiter(openXmlElement, value?.Miter);
      SetHeadEnd(openXmlElement, value?.HeadEnd);
      SetTailEnd(openXmlElement, value?.TailEnd);
      SetLinePropertiesExtensionList(openXmlElement, value?.LinePropertiesExtensionList);
      return openXmlElement;
    }
    return default;
  }
}