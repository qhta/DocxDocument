using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using CustomDash = DocumentModel.Drawings.CustomDash;
using GradientFill = DocumentModel.Drawings.GradientFill;
using LineEndPropertiesType = DocumentModel.Drawings.LineEndPropertiesType;
using LinePropertiesExtensionList = DocumentModel.Drawings.LinePropertiesExtensionList;
using Miter = DocumentModel.Drawings.Miter;
using Outline = DocumentFormat.OpenXml.Drawing.Outline;
using PatternFill = DocumentModel.Drawings.PatternFill;
using SolidFill = DocumentModel.Drawings.SolidFill;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the Outline Class.
/// </summary>
public static class OutlineConverter
{
  public static Boolean? GetNoFill(Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoFill>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoFill(Outline? openXmlElement, Boolean? value)
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

  public static SolidFill? GetSolidFill(Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSolidFill(Outline? openXmlElement, SolidFill? value)
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

  public static GradientFill? GetGradientFill(Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientFill(Outline? openXmlElement, GradientFill? value)
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

  public static PatternFill? GetPatternFill(Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPatternFill(Outline? openXmlElement, PatternFill? value)
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

  public static PresetLineDashKind? GetPresetDash(Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PresetDash>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<PresetLineDashValues, PresetLineDashKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetPresetDash(Outline? openXmlElement, PresetLineDashKind? value)
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

  public static CustomDash? GetCustomDash(Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
    if (itemElement != null)
      return CustomDashConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCustomDash(Outline? openXmlElement, CustomDash? value)
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

  public static Boolean? GetRound(Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Round>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetRound(Outline? openXmlElement, Boolean? value)
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

  public static Boolean? GetLineJoinBevel(Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LineJoinBevel>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetLineJoinBevel(Outline? openXmlElement, Boolean? value)
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

  public static Miter? GetMiter(Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Miter>();
    if (itemElement != null)
      return MiterConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMiter(Outline? openXmlElement, Miter? value)
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

  public static LineEndPropertiesType? GetHeadEnd(Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<HeadEnd>();
    if (itemElement != null)
      return LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHeadEnd(Outline? openXmlElement, LineEndPropertiesType? value)
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

  public static LineEndPropertiesType? GetTailEnd(Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TailEnd>();
    if (itemElement != null)
      return LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTailEnd(Outline? openXmlElement, LineEndPropertiesType? value)
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

  public static LinePropertiesExtensionList? GetLinePropertiesExtensionList(Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>();
    if (itemElement != null)
      return LinePropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLinePropertiesExtensionList(Outline? openXmlElement, LinePropertiesExtensionList? value)
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

  public static DocumentModel.Drawings.Outline? CreateModelElement(Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Outline();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Outline? value)
    where OpenXmlElementType : Outline, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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