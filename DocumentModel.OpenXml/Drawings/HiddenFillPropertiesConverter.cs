using DocumentFormat.OpenXml.Drawing;
using BlipFill = DocumentModel.Drawings.BlipFill;
using GradientFill = DocumentModel.Drawings.GradientFill;
using HiddenFillProperties = DocumentFormat.OpenXml.Office2010.Drawing.HiddenFillProperties;
using PatternFill = DocumentModel.Drawings.PatternFill;
using SolidFill = DocumentModel.Drawings.SolidFill;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the HiddenFillProperties Class.
/// </summary>
public static class HiddenFillPropertiesConverter
{
  /// <summary>
  ///   NoFill.
  /// </summary>
  public static Boolean? GetNoFill(HiddenFillProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoFill>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoFill(HiddenFillProperties? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   SolidFill.
  /// </summary>
  public static SolidFill? GetSolidFill(HiddenFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSolidFill(HiddenFillProperties? openXmlElement, SolidFill? value)
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

  /// <summary>
  ///   GradientFill.
  /// </summary>
  public static GradientFill? GetGradientFill(HiddenFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGradientFill(HiddenFillProperties? openXmlElement, GradientFill? value)
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

  /// <summary>
  ///   BlipFill.
  /// </summary>
  public static BlipFill? GetBlipFill(HiddenFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      return BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBlipFill(HiddenFillProperties? openXmlElement, BlipFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  public static PatternFill? GetPatternFill(HiddenFillProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPatternFill(HiddenFillProperties? openXmlElement, PatternFill? value)
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

  /// <summary>
  ///   Group Fill.
  /// </summary>
  public static Boolean? GetGroupFill(HiddenFillProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GroupFill>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetGroupFill(HiddenFillProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<GroupFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new GroupFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.HiddenFillProperties? CreateModelElement(HiddenFillProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HiddenFillProperties();
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HiddenFillProperties? value)
    where OpenXmlElementType : HiddenFillProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetGroupFill(openXmlElement, value?.GroupFill);
      return openXmlElement;
    }
    return default;
  }
}