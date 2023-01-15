using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using DisplayUnits = DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits;
using DisplayUnitsLabel = DocumentModel.Drawings.Charts.DisplayUnitsLabel;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DisplayUnits Class.
/// </summary>
public static class DisplayUnitsConverter
{
  public static Double? GetCustomDisplayUnit(DisplayUnits? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CustomDisplayUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCustomDisplayUnit(DisplayUnits? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CustomDisplayUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new CustomDisplayUnit { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BuiltInUnitKind? GetBuiltInUnit(DisplayUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BuiltInUnit>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<BuiltInUnitValues, BuiltInUnitKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBuiltInUnit(DisplayUnits? openXmlElement, BuiltInUnitKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BuiltInUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<BuiltInUnit, BuiltInUnitValues, BuiltInUnitKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DisplayUnitsLabel? GetDisplayUnitsLabel(DisplayUnits? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel>();
    if (itemElement != null)
      return DisplayUnitsLabelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDisplayUnitsLabel(DisplayUnits? openXmlElement, DisplayUnitsLabel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayUnitsLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DisplayUnits? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(DisplayUnits? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DisplayUnits? CreateModelElement(DisplayUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DisplayUnits();
      value.CustomDisplayUnit = GetCustomDisplayUnit(openXmlElement);
      value.BuiltInUnit = GetBuiltInUnit(openXmlElement);
      value.DisplayUnitsLabel = GetDisplayUnitsLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DisplayUnits? value)
    where OpenXmlElementType : DisplayUnits, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomDisplayUnit(openXmlElement, value?.CustomDisplayUnit);
      SetBuiltInUnit(openXmlElement, value?.BuiltInUnit);
      SetDisplayUnitsLabel(openXmlElement, value?.DisplayUnitsLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}