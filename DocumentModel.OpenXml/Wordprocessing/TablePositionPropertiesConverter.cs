namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public static class TablePositionPropertiesConverter
{
  /// <summary>
  /// Distance From Left of Table to Text
  /// </summary>
  public static Int16? GetLeftFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.LeftFromText?.Value;
  }
  
  public static void SetLeftFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.LeftFromText = value;
  }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  /// </summary>
  public static Int16? GetRightFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.RightFromText?.Value;
  }
  
  public static void SetRightFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.RightFromText = value;
  }
  
  /// <summary>
  /// Distance From Top of Table to Text
  /// </summary>
  public static Int16? GetTopFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.TopFromText?.Value;
  }
  
  public static void SetTopFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.TopFromText = value;
  }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  /// </summary>
  public static Int16? GetBottomFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.BottomFromText?.Value;
  }
  
  public static void SetBottomFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
      openXmlElement.BottomFromText = value;
  }
  
  /// <summary>
  /// Table Vertical Anchor
  /// </summary>
  public static DocumentModel.Wordprocessing.VerticalAnchorKind? GetVerticalAnchor(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DocumentModel.Wordprocessing.VerticalAnchorKind>(openXmlElement?.VerticalAnchor?.Value);
  }
  
  public static void SetVerticalAnchor(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.VerticalAnchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DocumentModel.Wordprocessing.VerticalAnchorKind>(value);
  }
  
  /// <summary>
  /// Table Horizontal Anchor
  /// </summary>
  public static DocumentModel.Wordprocessing.HorizontalAnchorKind? GetHorizontalAnchor(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DocumentModel.Wordprocessing.HorizontalAnchorKind>(openXmlElement?.HorizontalAnchor?.Value);
  }
  
  public static void SetHorizontalAnchor(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, DocumentModel.Wordprocessing.HorizontalAnchorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HorizontalAnchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DocumentModel.Wordprocessing.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment From Anchor
  /// </summary>
  public static DocumentModel.Wordprocessing.HorizontalAlignmentKind? GetTablePositionXAlignment(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DocumentModel.Wordprocessing.HorizontalAlignmentKind>(openXmlElement?.TablePositionXAlignment?.Value);
  }
  
  public static void SetTablePositionXAlignment(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, DocumentModel.Wordprocessing.HorizontalAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.TablePositionXAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DocumentModel.Wordprocessing.HorizontalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Horizontal Distance From Anchor
  /// </summary>
  public static Int32? GetTablePositionX(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.TablePositionX?.Value;
  }
  
  public static void SetTablePositionX(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.TablePositionX = value;
  }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  /// </summary>
  public static DocumentModel.Wordprocessing.VerticalAlignmentKind? GetTablePositionYAlignment(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DocumentModel.Wordprocessing.VerticalAlignmentKind>(openXmlElement?.TablePositionYAlignment?.Value);
  }
  
  public static void SetTablePositionYAlignment(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.TablePositionYAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DocumentModel.Wordprocessing.VerticalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Vertical Distance From Anchor
  /// </summary>
  public static Int32? GetTablePositionY(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    return openXmlElement?.TablePositionY?.Value;
  }
  
  public static void SetTablePositionY(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
