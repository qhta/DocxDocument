namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public static class FieldCharConverter
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  public static DocumentModel.Wordprocessing.FieldCharKind? GetFieldCharType(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FieldCharValues, DocumentModel.Wordprocessing.FieldCharKind>(openXmlElement?.FieldCharType?.Value);
  }
  
  public static void SetFieldCharType(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, DocumentModel.Wordprocessing.FieldCharKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FieldCharType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FieldCharValues, DocumentModel.Wordprocessing.FieldCharKind>(value);
  }
  
  /// <summary>
  /// Field Should Not Be Recalculated
  /// </summary>
  public static Boolean? GetFieldLock(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    return openXmlElement?.FieldLock?.Value;
  }
  
  public static void SetFieldLock(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FieldLock = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FieldLock = null;
  }
  
  /// <summary>
  /// Field Result Invalidated
  /// </summary>
  public static Boolean? GetDirty(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }
  
  public static void SetDirty(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Dirty = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Dirty = null;
  }
  
  /// <summary>
  /// Custom Field Data.
  /// </summary>
  public static String? GetFieldData(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldData>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetFieldData(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FieldData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Wordprocessing.FieldData { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.FormFieldData? GetFormFieldData(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldData>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FormFieldDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFormFieldData(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, DocumentModel.Wordprocessing.FormFieldData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.FormFieldDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FormFieldData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingChange? GetNumberingChange(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NumberingChangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNumberingChange(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, DocumentModel.Wordprocessing.NumberingChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Wordprocessing.NumberingChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.FieldChar? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.FieldChar();
      value.FieldCharType = GetFieldCharType(openXmlElement);
      value.FieldLock = GetFieldLock(openXmlElement);
      value.Dirty = GetDirty(openXmlElement);
      value.FieldData = GetFieldData(openXmlElement);
      value.FormFieldData = GetFormFieldData(openXmlElement);
      value.NumberingChange = GetNumberingChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.FieldChar? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.FieldChar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFieldCharType(openXmlElement, value?.FieldCharType);
      SetFieldLock(openXmlElement, value?.FieldLock);
      SetDirty(openXmlElement, value?.Dirty);
      SetFieldData(openXmlElement, value?.FieldData);
      SetFormFieldData(openXmlElement, value?.FormFieldData);
      SetNumberingChange(openXmlElement, value?.NumberingChange);
      return openXmlElement;
    }
    return default;
  }
}
