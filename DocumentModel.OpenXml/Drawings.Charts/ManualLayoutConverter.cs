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
  
}
