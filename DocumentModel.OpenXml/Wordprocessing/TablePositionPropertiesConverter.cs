namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TablePositionProperties Class.
/// </summary>
public static class TablePositionPropertiesConverter
{
  /// <summary>
  /// Distance From Left of Table to Text
  /// </summary>
  private static Int16? GetLeftFromText(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement.LeftFromText?.Value;
  }
  
  private static void SetLeftFromText(DXW.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.LeftFromText = value;
  }
  
  /// <summary>
  /// (Distance From Right of Table to Text
  /// </summary>
  private static Int16? GetRightFromText(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement.RightFromText?.Value;
  }
  
  private static void SetRightFromText(DXW.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.RightFromText = value;
  }
  
  /// <summary>
  /// Distance From Top of Table to Text
  /// </summary>
  private static Int16? GetTopFromText(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement.TopFromText?.Value;
  }
  
  private static void SetTopFromText(DXW.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.TopFromText = value;
  }
  
  /// <summary>
  /// Distance From Bottom of Table to Text
  /// </summary>
  private static Int16? GetBottomFromText(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement.BottomFromText?.Value;
  }
  
  private static void SetBottomFromText(DXW.TablePositionProperties openXmlElement, Int16? value)
  {
    openXmlElement.BottomFromText = value;
  }
  
  /// <summary>
  /// Table Vertical Anchor
  /// </summary>
  private static DMW.VerticalAnchorKind? GetVerticalAnchor(DXW.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DMW.VerticalAnchorKind>(openXmlElement?.VerticalAnchor?.Value);
  }
  
  private static void SetVerticalAnchor(DXW.TablePositionProperties openXmlElement, DMW.VerticalAnchorKind? value)
  {
    openXmlElement.VerticalAnchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAnchorValues, DMW.VerticalAnchorKind>(value);
  }
  
  /// <summary>
  /// Table Horizontal Anchor
  /// </summary>
  private static DMW.HorizontalAnchorKind? GetHorizontalAnchor(DXW.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DMW.HorizontalAnchorKind>(openXmlElement?.HorizontalAnchor?.Value);
  }
  
  private static void SetHorizontalAnchor(DXW.TablePositionProperties openXmlElement, DMW.HorizontalAnchorKind? value)
  {
    openXmlElement.HorizontalAnchor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAnchorValues, DMW.HorizontalAnchorKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment From Anchor
  /// </summary>
  private static DMW.HorizontalAlignmentKind? GetTablePositionXAlignment(DXW.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(openXmlElement?.TablePositionXAlignment?.Value);
  }
  
  private static void SetTablePositionXAlignment(DXW.TablePositionProperties openXmlElement, DMW.HorizontalAlignmentKind? value)
  {
    openXmlElement.TablePositionXAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HorizontalAlignmentValues, DMW.HorizontalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Horizontal Distance From Anchor
  /// </summary>
  private static Int32? GetTablePositionX(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement.TablePositionX?.Value;
  }
  
  private static void SetTablePositionX(DXW.TablePositionProperties openXmlElement, Int32? value)
  {
    openXmlElement.TablePositionX = value;
  }
  
  /// <summary>
  /// Relative Vertical Alignment from Anchor
  /// </summary>
  private static DMW.VerticalAlignmentKind? GetTablePositionYAlignment(DXW.TablePositionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(openXmlElement?.TablePositionYAlignment?.Value);
  }
  
  private static void SetTablePositionYAlignment(DXW.TablePositionProperties openXmlElement, DMW.VerticalAlignmentKind? value)
  {
    openXmlElement.TablePositionYAlignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalAlignmentValues, DMW.VerticalAlignmentKind>(value);
  }
  
  /// <summary>
  /// Absolute Vertical Distance From Anchor
  /// </summary>
  private static Int32? GetTablePositionY(DXW.TablePositionProperties openXmlElement)
  {
    return openXmlElement.TablePositionY?.Value;
  }
  
  private static void SetTablePositionY(DXW.TablePositionProperties openXmlElement, Int32? value)
  {
    openXmlElement.TablePositionY = value;
  }
  
  public static DMW.TablePositionProperties? CreateModelElement(DXW.TablePositionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TablePositionProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePositionProperties? value)
    where OpenXmlElementType: DXW.TablePositionProperties, new()
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
