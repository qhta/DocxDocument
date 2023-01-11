namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
public static class ManualLayoutConverter
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  public static DocumentModel.Drawings.Charts.LayoutTargetKind? GetLayoutTarget(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LayoutTarget>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DocumentModel.Drawings.Charts.LayoutTargetKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLayoutTarget(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, DocumentModel.Drawings.Charts.LayoutTargetKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  public static DocumentModel.Drawings.Charts.LayoutMode? GetLeftMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LeftMode>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLeftMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, DocumentModel.Drawings.Charts.LayoutMode? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  public static DocumentModel.Drawings.Charts.LayoutMode? GetTopMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TopMode>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTopMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, DocumentModel.Drawings.Charts.LayoutMode? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  public static DocumentModel.Drawings.Charts.LayoutMode? GetWidthMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.WidthMode>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetWidthMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, DocumentModel.Drawings.Charts.LayoutMode? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  public static DocumentModel.Drawings.Charts.LayoutMode? GetHeightMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.HeightMode>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutModeValues, DocumentModel.Drawings.Charts.LayoutMode>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHeightMode(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, DocumentModel.Drawings.Charts.LayoutMode? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Left.
  /// </summary>
  public static Double? GetLeft(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Left");
  }
  
  public static void SetLeft(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Left");
  }
  
  /// <summary>
  /// Top.
  /// </summary>
  public static Double? GetTop(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Top");
  }
  
  public static void SetTop(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Top");
  }
  
  /// <summary>
  /// Width.
  /// </summary>
  public static Double? GetWidth(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Width");
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Width");
  }
  
  /// <summary>
  /// Height.
  /// </summary>
  public static Double? GetHeight(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Height");
  }
  
  public static void SetHeight(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.Height");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ManualLayout? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
