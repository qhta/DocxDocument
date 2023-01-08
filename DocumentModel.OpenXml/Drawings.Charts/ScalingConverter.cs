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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLogBase(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMaxAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Minimum.
  /// </summary>
  public static Double? GetMinAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMinAxisValue(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
