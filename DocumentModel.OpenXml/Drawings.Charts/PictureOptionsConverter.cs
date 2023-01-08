namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public static class PictureOptionsConverter
{
  /// <summary>
  /// Apply To Front.
  /// </summary>
  public static Boolean? GetApplyToFront(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetApplyToFront(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Apply To Sides.
  /// </summary>
  public static Boolean? GetApplyToSides(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetApplyToSides(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Apply to End.
  /// </summary>
  public static Boolean? GetApplyToEnd(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetApplyToEnd(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Picture Format.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PictureFormatKind? GetPictureFormat(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DocumentModel.Drawings.Charts.PictureFormatKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPictureFormat(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement, DocumentModel.Drawings.Charts.PictureFormatKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// Picture Stack Unit.
  /// </summary>
  public static Double? GetPictureStackUnit(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPictureStackUnit(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
