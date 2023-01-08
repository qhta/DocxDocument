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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLeftFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  /// </summary>
  public static Int16? GetRightFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRightFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Distance From Top of Table to Text
  /// </summary>
  public static Int16? GetTopFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTopFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  /// </summary>
  public static Int16? GetBottomFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBottomFromText(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTablePositionX(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTablePositionY(DocumentFormat.OpenXml.Wordprocessing.TablePositionProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
