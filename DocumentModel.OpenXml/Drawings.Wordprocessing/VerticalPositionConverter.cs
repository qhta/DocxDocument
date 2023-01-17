namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Vertical Positioning.
/// </summary>
public static class VerticalPositionConverter
{
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  private static DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind? GetRelativeFrom(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  private static void SetRelativeFrom(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement, DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DocumentModel.Drawings.Wordprocessing.VerticalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Vertical Alignment.
  /// </summary>
  private static String? GetVerticalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetVerticalAlignment(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalAlignment { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PositionOffset.
  /// </summary>
  private static String? GetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Wordprocessing.PositionOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetPositionOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement, String? value)
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
  /// PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  private static String? GetPercentagePositionVerticalOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetPercentagePositionVerticalOffset(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2010.Word.Drawing.PercentagePositionVerticalOffset { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.VerticalPosition? CreateModelElement(DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.VerticalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.VerticalAlignment = GetVerticalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionVerticalOffset = GetPercentagePositionVerticalOffset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.VerticalPosition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalPosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeFrom(openXmlElement, value?.RelativeFrom);
      SetVerticalAlignment(openXmlElement, value?.VerticalAlignment);
      SetPositionOffset(openXmlElement, value?.PositionOffset);
      SetPercentagePositionVerticalOffset(openXmlElement, value?.PercentagePositionVerticalOffset);
      return openXmlElement;
    }
    return default;
  }
}
