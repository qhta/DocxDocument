namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
public static class ManualLayoutConverter
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  private static DocumentModel.Drawings.Charts.LayoutTargetKind? GetLayoutTarget(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LayoutTarget>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DocumentModel.Drawings.Charts.LayoutTargetKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLayoutTarget(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, DocumentModel.Drawings.Charts.LayoutTargetKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LayoutTarget>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutTarget, DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DocumentModel.Drawings.Charts.LayoutTargetKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  private static DocumentModel.Drawings.Charts.LayoutMode? GetLeftMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LeftMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLeftMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, DocumentModel.Drawings.Charts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LeftMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LeftMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  private static DocumentModel.Drawings.Charts.LayoutMode? GetTopMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TopMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTopMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, DocumentModel.Drawings.Charts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TopMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TopMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  private static DocumentModel.Drawings.Charts.LayoutMode? GetWidthMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.WidthMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetWidthMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, DocumentModel.Drawings.Charts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.WidthMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.WidthMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  private static DocumentModel.Drawings.Charts.LayoutMode? GetHeightMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeightMode>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHeightMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, DocumentModel.Drawings.Charts.LayoutMode? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeightMode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.HeightMode, DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Left.
  /// </summary>
  private static Double? GetLeft(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Left>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLeft(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Left>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Left{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Top.
  /// </summary>
  private static Double? GetTop(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Top>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTop(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Top>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Top{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Width.
  /// </summary>
  private static Double? GetWidth(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Width>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Width>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Width{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Height.
  /// </summary>
  private static Double? GetHeight(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Height>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetHeight(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Height>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Height{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ManualLayout? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ManualLayout, new()
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
