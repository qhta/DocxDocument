namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public static class LevelConverter
{
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.NumberingFormat? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public static DocumentModel.Wordprocessing.LevelSuffixKind? GetLevelSuffix(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelSuffix>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DocumentModel.Wordprocessing.LevelSuffixKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLevelSuffix(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.LevelSuffixKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelSuffix>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelSuffix, DocumentFormat.OpenXml.Wordprocessing.LevelSuffixValues, DocumentModel.Wordprocessing.LevelSuffixKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public static DocumentModel.Wordprocessing.LevelJustificationKind? GetLevelJustification(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DocumentModel.Wordprocessing.LevelJustificationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLevelJustification(DocumentFormat.OpenXml.Wordprocessing.Level? openXmlElement, DocumentModel.Wordprocessing.LevelJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LevelJustification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LevelJustification, DocumentFormat.OpenXml.Wordprocessing.LevelJustificationValues, DocumentModel.Wordprocessing.LevelJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
