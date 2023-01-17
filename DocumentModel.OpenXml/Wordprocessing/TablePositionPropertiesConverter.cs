namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public static class TablePositionPropertiesConverter
{
  /// <summary>
  /// Distance From Left of Table to Text
  /// </summary>
  private static Int16? GetLeftFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return openXmlElement.LeftFromText?.Value;
  }
  
  private static void SetLeftFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.LeftFromText = value;
  }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  /// </summary>
  private static Int16? GetRightFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return openXmlElement.RightFromText?.Value;
  }
  
  private static void SetRightFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.RightFromText = value;
  }
  
  /// <summary>
  /// Distance From Top of Table to Text
  /// </summary>
  private static Int16? GetTopFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return openXmlElement.TopFromText?.Value;
  }
  
  private static void SetTopFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.TopFromText = value;
  }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  /// </summary>
  private static Int16? GetBottomFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return openXmlElement.BottomFromText?.Value;
  }
  
  private static void SetBottomFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.BottomFromText = value;
  }
  
  /// <summary>
  /// Table Vertical Anchor
  /// </summary>
  private static DocumentModel.Wordprocessing.VerticalAnchorKind? GetVerticalAnchor(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DocumentModel.Wordprocessing.VerticalAnchorKind>(openXmlElement?.VerticalAnchor?.Value);
  }
  
  private static void SetVerticalAnchor(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, DocumentModel.Wordprocessing.VerticalAnchorKind? value)
  {
    openXmlElement.VerticalAnchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DocumentModel.Wordprocessing.VerticalAnchorKind>(value);
  }
  
  /// <summary>
  /// Table Horizontal Anchor
  /// </summary>
  private static DocumentModel.Wordprocessing.HorizontalAnchorKind? GetHorizontalAnchor(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DocumentModel.Wordprocessing.HorizontalAnchorKind>(openXmlElement?.HorizontalAnchor?.Value);
  }
  
  private static void SetHorizontalAnchor(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, DocumentModel.Wordprocessing.HorizontalAnchorKind? value)
  {
    openXmlElement.HorizontalAnchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DocumentModel.Wordprocessing.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment From Anchor
  /// </summary>
  private static DocumentModel.Wordprocessing.HorizontalAlignmentKind? GetTablePositionXAlignment(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DocumentModel.Wordprocessing.HorizontalAlignmentKind>(openXmlElement?.TablePositionXAlignment?.Value);
  }
  
  private static void SetTablePositionXAlignment(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, DocumentModel.Wordprocessing.HorizontalAlignmentKind? value)
  {
    openXmlElement.TablePositionXAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DocumentModel.Wordprocessing.HorizontalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Horizontal Distance From Anchor
  /// </summary>
  private static Int32? GetTablePositionX(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return openXmlElement.TablePositionX?.Value;
  }
  
  private static void SetTablePositionX(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, Int32? value)
  {
    openXmlElement.TablePositionX = value;
  }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  /// </summary>
  private static DocumentModel.Wordprocessing.VerticalAlignmentKind? GetTablePositionYAlignment(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DocumentModel.Wordprocessing.VerticalAlignmentKind>(openXmlElement?.TablePositionYAlignment?.Value);
  }
  
  private static void SetTablePositionYAlignment(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, DocumentModel.Wordprocessing.VerticalAlignmentKind? value)
  {
    openXmlElement.TablePositionYAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DocumentModel.Wordprocessing.VerticalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Vertical Distance From Anchor
  /// </summary>
  private static Int32? GetTablePositionY(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement)
  {
    return openXmlElement.TablePositionY?.Value;
  }
  
  private static void SetTablePositionY(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties openXmlElement, Int32? value)
  {
    openXmlElement.TablePositionY = value;
  }
  
  public static DocumentModel.Wordprocessing.TablePositionProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TablePositionProperties();
      value.LeftFromText = GetLeftFromText(openXmlElement);
      value.RightFromText = GetRightFromText(openXmlElement);
      value.TopFromText = GetTopFromText(openXmlElement);
      value.BottomFromText = GetBottomFromText(openXmlElement);
      value.VerticalAnchor = GetVerticalAnchor(openXmlElement);
      value.HorizontalAnchor = GetHorizontalAnchor(openXmlElement);
      value.TablePositionXAlignment = GetTablePositionXAlignment(openXmlElement);
      value.TablePositionX = GetTablePositionX(openXmlElement);
      value.TablePositionYAlignment = GetTablePositionYAlignment(openXmlElement);
      value.TablePositionY = GetTablePositionY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TablePositionProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLeftFromText(openXmlElement, value?.LeftFromText);
      SetRightFromText(openXmlElement, value?.RightFromText);
      SetTopFromText(openXmlElement, value?.TopFromText);
      SetBottomFromText(openXmlElement, value?.BottomFromText);
      SetVerticalAnchor(openXmlElement, value?.VerticalAnchor);
      SetHorizontalAnchor(openXmlElement, value?.HorizontalAnchor);
      SetTablePositionXAlignment(openXmlElement, value?.TablePositionXAlignment);
      SetTablePositionX(openXmlElement, value?.TablePositionX);
      SetTablePositionYAlignment(openXmlElement, value?.TablePositionYAlignment);
      SetTablePositionY(openXmlElement, value?.TablePositionY);
      return openXmlElement;
    }
    return default;
  }
}
