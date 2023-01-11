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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CheckedState>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CheckBoxSymbolTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCheckedState(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement, DocumentModel.Wordprocessing.CheckBoxSymbolType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.CheckedState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CheckBoxSymbolTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.CheckedState>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public static DocumentModel.Wordprocessing.CheckBoxSymbolType? GetUncheckedState(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.UncheckedState>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.CheckBoxSymbolTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetUncheckedState(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement, DocumentModel.Wordprocessing.CheckBoxSymbolType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.UncheckedState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.CheckBoxSymbolTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.UncheckedState>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtContentCheckBox? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentCheckBox();
      value.Checked = GetChecked(openXmlElement);
      value.CheckedState = GetCheckedState(openXmlElement);
      value.UncheckedState = GetUncheckedState(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtContentCheckBox? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
