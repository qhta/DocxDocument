namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public static class PictureOptionsConverter
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  private static Boolean? GetApplyToFront(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToFront>();
    return itemElement != null;
  }
  
  private static void SetApplyToFront(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToFront>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ApplyToFront();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  private static Boolean? GetApplyToSides(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToSides>();
    return itemElement != null;
  }
  
  private static void SetApplyToSides(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToSides>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ApplyToSides();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  private static Boolean? GetApplyToEnd(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToEnd>();
    return itemElement != null;
  }
  
  private static void SetApplyToEnd(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ApplyToEnd>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ApplyToEnd();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  private static DocumentModel.Drawings.Charts.PictureFormatKind? GetPictureFormat(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DocumentModel.Drawings.Charts.PictureFormatKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPictureFormat(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement, DocumentModel.Drawings.Charts.PictureFormatKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat, DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DocumentModel.Drawings.Charts.PictureFormatKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  private static Double? GetPictureStackUnit(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureStackUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPictureStackUnit(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureStackUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.PictureStackUnit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PictureOptions? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PictureOptions();
      value.ApplyToFront = GetApplyToFront(openXmlElement);
      value.ApplyToSides = GetApplyToSides(openXmlElement);
      value.ApplyToEnd = GetApplyToEnd(openXmlElement);
      value.PictureFormat = GetPictureFormat(openXmlElement);
      value.PictureStackUnit = GetPictureStackUnit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PictureOptions? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PictureOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetApplyToFront(openXmlElement, value?.ApplyToFront);
      SetApplyToSides(openXmlElement, value?.ApplyToSides);
      SetApplyToEnd(openXmlElement, value?.ApplyToEnd);
      SetPictureFormat(openXmlElement, value?.PictureFormat);
      SetPictureStackUnit(openXmlElement, value?.PictureStackUnit);
      return openXmlElement;
    }
    return default;
  }
}
