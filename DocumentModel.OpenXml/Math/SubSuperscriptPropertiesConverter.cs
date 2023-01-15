using DocumentFormat.OpenXml.Math;
using DocumentModel.Math;
using ControlProperties = DocumentModel.Math.ControlProperties;
using SubSuperscriptProperties = DocumentFormat.OpenXml.Math.SubSuperscriptProperties;

namespace DocumentModel.OpenXml.Math;

/// <summary>
///   Sub-Superscript Properties.
/// </summary>
public static class SubSuperscriptPropertiesConverter
{
  /// <summary>
  ///   Align Scripts.
  /// </summary>
  public static BooleanKind? GetAlignScripts(SubSuperscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlignScripts>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BooleanValues, BooleanKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAlignScripts(SubSuperscriptProperties? openXmlElement, BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AlignScripts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<AlignScripts, BooleanValues, BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public static ControlProperties? GetControlProperties(SubSuperscriptProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlProperties(SubSuperscriptProperties? openXmlElement, ControlProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Math.SubSuperscriptProperties? CreateModelElement(SubSuperscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.SubSuperscriptProperties();
      value.AlignScripts = GetAlignScripts(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.SubSuperscriptProperties? value)
    where OpenXmlElementType : SubSuperscriptProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlignScripts(openXmlElement, value?.AlignScripts);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}