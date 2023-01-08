namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition.
/// </summary>
public static class AbstractNumConverter
{
  /// <summary>
  /// Abstract Numbering Definition Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.MultiLevelKind? GetMultiLevelType(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MultiLevelType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DocumentModel.Wordprocessing.MultiLevelKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMultiLevelType(DocumentFormat.OpenXml.Wordprocessing.AbstractNum? openXmlElement, DocumentModel.Wordprocessing.MultiLevelKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MultiLevelType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MultiLevelType, DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DocumentModel.Wordprocessing.MultiLevelKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
