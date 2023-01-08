namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Group-Character Properties.
/// </summary>
public static class GroupCharPropertiesConverter
{
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  public static String? GetAccentChar(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Math.AccentChar");
  }
  
  public static void SetAccentChar(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Position (Group Character).
  /// </summary>
  public static DocumentModel.Math.VerticalJustificationKind? GetPosition(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DocumentModel.Math.VerticalJustificationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement, DocumentModel.Math.VerticalJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Position, DocumentFormat.OpenXml.Math.VerticalJustificationValues, DocumentModel.Math.VerticalJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  public static DocumentModel.Math.VerticalJustificationKind? GetVerticalJustification(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.VerticalJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DocumentModel.Math.VerticalJustificationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetVerticalJustification(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement, DocumentModel.Math.VerticalJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.VerticalJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.VerticalJustification, DocumentFormat.OpenXml.Math.VerticalJustificationValues, DocumentModel.Math.VerticalJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
