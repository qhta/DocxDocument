namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scaling.
/// </summary>
public static class ScalingConverter
{
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  private static Double? GetLogBase(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LogBase>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetLogBase(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LogBase>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.LogBase{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  private static DocumentModel.Drawings.Charts.OrientationKind? GetOrientation(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Orientation>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DocumentModel.Drawings.Charts.OrientationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetOrientation(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement, DocumentModel.Drawings.Charts.OrientationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Orientation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Orientation, DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DocumentModel.Drawings.Charts.OrientationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  private static Double? GetMaxAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MaxAxisValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMaxAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MaxAxisValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.MaxAxisValue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  private static Double? GetMinAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinAxisValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMinAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinAxisValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.MinAxisValue{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Scaling openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.Scaling? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Scaling, new()
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
