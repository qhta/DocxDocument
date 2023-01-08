namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Fraction Properties.
/// </summary>
public static class FractionPropertiesConverter
{
  /// <summary>
  /// Fraction type.
  /// </summary>
  public static DocumentModel.Math.FractionKind? GetFractionType(DocumentFormat.OpenXml.Math.FractionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.FractionTypeValues, DocumentModel.Math.FractionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetFractionType(DocumentFormat.OpenXml.Math.FractionProperties? openXmlElement, DocumentModel.Math.FractionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.FractionType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.FractionType, DocumentFormat.OpenXml.Math.FractionTypeValues, DocumentModel.Math.FractionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.FractionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.FractionProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
