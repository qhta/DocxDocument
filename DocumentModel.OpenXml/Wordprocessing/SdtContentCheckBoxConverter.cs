namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public static class SdtContentCheckBoxConverter
{
  /// <summary>
  /// Checked.
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffKind? GetChecked(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Checked>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetChecked(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement, DocumentModel.Wordprocessing.OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Checked>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.Checked, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DocumentModel.Wordprocessing.OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public static DocumentModel.Wordprocessing.CheckBoxSymbolType? GetCheckedState(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCheckedState(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement, DocumentModel.Wordprocessing.CheckBoxSymbolType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public static DocumentModel.Wordprocessing.CheckBoxSymbolType? GetUncheckedState(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUncheckedState(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement, DocumentModel.Wordprocessing.CheckBoxSymbolType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
