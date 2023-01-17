namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Group-Character Properties.
/// </summary>
public static class GroupCharPropertiesConverter
{
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  private static String? GetAccentChar(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.AccentChar>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetAccentChar(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AccentChar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Math.AccentChar { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Position (Group Character).
  /// </summary>
  private static DocumentModel.Math.VerticalJustificationKind? GetPosition(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DocumentModel.Math.VerticalJustificationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPosition(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement, DocumentModel.Math.VerticalJustificationKind? value)
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
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  private static DocumentModel.Math.VerticalJustificationKind? GetVerticalJustification(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.VerticalJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalJustificationValues, DocumentModel.Math.VerticalJustificationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetVerticalJustification(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement, DocumentModel.Math.VerticalJustificationKind? value)
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
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DocumentFormat.OpenXml.Math.GroupCharProperties openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.GroupCharProperties? CreateModelElement(DocumentFormat.OpenXml.Math.GroupCharProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.GroupCharProperties();
      value.AccentChar = GetAccentChar(openXmlElement);
      value.Position = GetPosition(openXmlElement);
      value.VerticalJustification = GetVerticalJustification(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.GroupCharProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.GroupCharProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentChar(openXmlElement, value?.AccentChar);
      SetPosition(openXmlElement, value?.Position);
      SetVerticalJustification(openXmlElement, value?.VerticalJustification);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
