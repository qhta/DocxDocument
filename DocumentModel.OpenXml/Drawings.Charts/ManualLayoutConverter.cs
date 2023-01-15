using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ManualLayout = DocumentFormat.OpenXml.Drawing.Charts.ManualLayout;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Manual Layout.
/// </summary>
public static class ManualLayoutConverter
{
  /// <summary>
  ///   Layout Target.
  /// </summary>
  public static LayoutTargetKind? GetLayoutTarget(ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LayoutTarget>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LayoutTargetValues, LayoutTargetKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLayoutTarget(ManualLayout? openXmlElement, LayoutTargetKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LayoutTarget>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<LayoutTarget, LayoutTargetValues, LayoutTargetKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Left Mode.
  /// </summary>
  public static LayoutMode? GetLeftMode(ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftMode>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LayoutModeValues, LayoutMode>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLeftMode(ManualLayout? openXmlElement, LayoutMode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LeftMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<LeftMode, LayoutModeValues, LayoutMode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Top Mode.
  /// </summary>
  public static LayoutMode? GetTopMode(ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopMode>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LayoutModeValues, LayoutMode>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTopMode(ManualLayout? openXmlElement, LayoutMode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TopMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TopMode, LayoutModeValues, LayoutMode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Width Mode.
  /// </summary>
  public static LayoutMode? GetWidthMode(ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WidthMode>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LayoutModeValues, LayoutMode>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetWidthMode(ManualLayout? openXmlElement, LayoutMode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WidthMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<WidthMode, LayoutModeValues, LayoutMode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Height Mode.
  /// </summary>
  public static LayoutMode? GetHeightMode(ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HeightMode>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LayoutModeValues, LayoutMode>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHeightMode(ManualLayout? openXmlElement, LayoutMode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HeightMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<HeightMode, LayoutModeValues, LayoutMode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Left.
  /// </summary>
  public static Double? GetLeft(ManualLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Left>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLeft(ManualLayout? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Left>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Left { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Top.
  /// </summary>
  public static Double? GetTop(ManualLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Top>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTop(ManualLayout? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Top>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Top { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Width.
  /// </summary>
  public static Double? GetWidth(ManualLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Width>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetWidth(ManualLayout? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Width>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Width { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Height.
  /// </summary>
  public static Double? GetHeight(ManualLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Height>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetHeight(ManualLayout? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Height>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Height { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(ManualLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ManualLayout? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.ManualLayout? CreateModelElement(ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ManualLayout();
      value.LayoutTarget = GetLayoutTarget(openXmlElement);
      value.LeftMode = GetLeftMode(openXmlElement);
      value.TopMode = GetTopMode(openXmlElement);
      value.WidthMode = GetWidthMode(openXmlElement);
      value.HeightMode = GetHeightMode(openXmlElement);
      value.Left = GetLeft(openXmlElement);
      value.Top = GetTop(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Height = GetHeight(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ManualLayout? value)
    where OpenXmlElementType : ManualLayout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLayoutTarget(openXmlElement, value?.LayoutTarget);
      SetLeftMode(openXmlElement, value?.LeftMode);
      SetTopMode(openXmlElement, value?.TopMode);
      SetWidthMode(openXmlElement, value?.WidthMode);
      SetHeightMode(openXmlElement, value?.HeightMode);
      SetLeft(openXmlElement, value?.Left);
      SetTop(openXmlElement, value?.Top);
      SetWidth(openXmlElement, value?.Width);
      SetHeight(openXmlElement, value?.Height);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}