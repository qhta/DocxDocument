using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using FieldChar = DocumentFormat.OpenXml.Wordprocessing.FieldChar;
using FormFieldData = DocumentModel.Wordprocessing.FormFieldData;
using NumberingChange = DocumentModel.Wordprocessing.NumberingChange;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Complex Field Character.
/// </summary>
public static class FieldCharConverter
{
  /// <summary>
  ///   Field Character Type
  /// </summary>
  public static FieldCharKind? GetFieldCharType(FieldChar? openXmlElement)
  {
    return EnumValueConverter.GetValue<FieldCharValues, FieldCharKind>(openXmlElement?.FieldCharType?.Value);
  }

  public static void SetFieldCharType(FieldChar? openXmlElement, FieldCharKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FieldCharType = EnumValueConverter.CreateEnumValue<FieldCharValues, FieldCharKind>(value);
  }

  /// <summary>
  ///   Field Should Not Be Recalculated
  /// </summary>
  public static Boolean? GetFieldLock(FieldChar? openXmlElement)
  {
    return openXmlElement?.FieldLock?.Value;
  }

  public static void SetFieldLock(FieldChar? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.FieldLock = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.FieldLock = null;
  }

  /// <summary>
  ///   Field Result Invalidated
  /// </summary>
  public static Boolean? GetDirty(FieldChar? openXmlElement)
  {
    return openXmlElement?.Dirty?.Value;
  }

  public static void SetDirty(FieldChar? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Dirty = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Dirty = null;
  }

  /// <summary>
  ///   Custom Field Data.
  /// </summary>
  public static String? GetFieldData(FieldChar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FieldData>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFieldData(FieldChar? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FieldData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FieldData { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Form Field Properties.
  /// </summary>
  public static FormFieldData? GetFormFieldData(FieldChar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldData>();
    if (itemElement != null)
      return FormFieldDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormFieldData(FieldChar? openXmlElement, FormFieldData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FormFieldData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormFieldDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FormFieldData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Previous Numbering Field Properties.
  /// </summary>
  public static NumberingChange? GetNumberingChange(FieldChar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
    if (itemElement != null)
      return NumberingChangeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingChange(FieldChar? openXmlElement, NumberingChange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingChangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingChange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.FieldChar? CreateModelElement(FieldChar? openXmlElement)
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
    where OpenXmlElementType : FieldChar, new()
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