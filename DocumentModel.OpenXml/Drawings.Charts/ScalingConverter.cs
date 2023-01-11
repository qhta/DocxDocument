namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scaling.
/// </summary>
public static class ScalingConverter
{
  /// <summary>
  /// Logarithmic Base.
  /// </summary>
  public static Double? GetLogBase(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.LogBase");
  }
  
  public static void SetLogBase(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.LogBase");
  }
  
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  public static DocumentModel.Drawings.Charts.OrientationKind? GetOrientation(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Orientation>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DocumentModel.Drawings.Charts.OrientationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetOrientation(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, DocumentModel.Drawings.Charts.OrientationKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Maximum.
  /// </summary>
  public static Double? GetMaxAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.MaxAxisValue");
  }
  
  public static void SetMaxAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.MaxAxisValue");
  }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  public static Double? GetMinAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.MinAxisValue");
  }
  
  public static void SetMinAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.MinAxisValue");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
