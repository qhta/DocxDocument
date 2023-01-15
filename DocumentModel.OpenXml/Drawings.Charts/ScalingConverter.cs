using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using Scaling = DocumentFormat.OpenXml.Drawing.Charts.Scaling;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Scaling.
/// </summary>
public static class ScalingConverter
{
  /// <summary>
  ///   Logarithmic Base.
  /// </summary>
  public static Double? GetLogBase(Scaling? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LogBase>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLogBase(Scaling? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LogBase>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LogBase { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Axis Orientation.
  /// </summary>
  public static OrientationKind? GetOrientation(Scaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Orientation>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OrientationValues, OrientationKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetOrientation(Scaling? openXmlElement, OrientationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Orientation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Orientation, OrientationValues, OrientationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Maximum.
  /// </summary>
  public static Double? GetMaxAxisValue(Scaling? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MaxAxisValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMaxAxisValue(Scaling? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MaxAxisValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MaxAxisValue { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Minimum.
  /// </summary>
  public static Double? GetMinAxisValue(Scaling? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MinAxisValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMinAxisValue(Scaling? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinAxisValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MinAxisValue { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(Scaling? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Scaling? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.Scaling? CreateModelElement(Scaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Scaling();
      value.LogBase = GetLogBase(openXmlElement);
      value.Orientation = GetOrientation(openXmlElement);
      value.MaxAxisValue = GetMaxAxisValue(openXmlElement);
      value.MinAxisValue = GetMinAxisValue(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Scaling? value)
    where OpenXmlElementType : Scaling, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLogBase(openXmlElement, value?.LogBase);
      SetOrientation(openXmlElement, value?.Orientation);
      SetMaxAxisValue(openXmlElement, value?.MaxAxisValue);
      SetMinAxisValue(openXmlElement, value?.MinAxisValue);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}