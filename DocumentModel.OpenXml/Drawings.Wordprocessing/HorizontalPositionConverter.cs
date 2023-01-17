namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public static class HorizontalPositionConverter
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  private static DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind? GetRelativeFrom(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  private static void SetRelativeFrom(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement, DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DocumentModel.Drawings.Wordprocessing.HorizontalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  private static String? GetHorizontalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetHorizontalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalAlignment { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  private static String? GetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  private static String? GetPercentagePositionHeightOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetPercentagePositionHeightOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionHeightOffset { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.HorizontalPosition? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.HorizontalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.HorizontalAlignment = GetHorizontalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionHeightOffset = GetPercentagePositionHeightOffset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.HorizontalPosition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalPosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeFrom(openXmlElement, value?.RelativeFrom);
      SetHorizontalAlignment(openXmlElement, value?.HorizontalAlignment);
      SetPositionOffset(openXmlElement, value?.PositionOffset);
      SetPercentagePositionHeightOffset(openXmlElement, value?.PercentagePositionHeightOffset);
      return openXmlElement;
    }
    return default;
  }
}
