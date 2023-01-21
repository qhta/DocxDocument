namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
public static class SdtPlaceholderConverter
{
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  private static String? GetDocPartReference(DXW.SdtPlaceholder openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartReference>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDocPartReference(DXW.SdtPlaceholder openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.DocPartReference { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtPlaceholder? CreateModelElement(DXW.SdtPlaceholder? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtPlaceholder();
      value.DocPartReference = GetDocPartReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtPlaceholder? value)
    where OpenXmlElementType: DXW.SdtPlaceholder, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocPartReference(openXmlElement, value?.DocPartReference);
      return openXmlElement;
    }
    return default;
  }
}
