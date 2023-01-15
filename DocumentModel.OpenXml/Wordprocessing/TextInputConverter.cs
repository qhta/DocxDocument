using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using TextInput = DocumentFormat.OpenXml.Wordprocessing.TextInput;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Text Box Form Field Properties.
/// </summary>
public static class TextInputConverter
{
  /// <summary>
  ///   Text Box Form Field Type.
  /// </summary>
  public static TextBoxFormFieldKind? GetTextBoxFormFieldType(TextInput? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextBoxFormFieldType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TextBoxFormFieldValues, TextBoxFormFieldKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTextBoxFormFieldType(TextInput? openXmlElement, TextBoxFormFieldKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TextBoxFormFieldType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TextBoxFormFieldType, TextBoxFormFieldValues, TextBoxFormFieldKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Default Text Box Form Field String.
  /// </summary>
  public static String? GetDefaultTextBoxFormFieldString(TextInput? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DefaultTextBoxFormFieldString>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDefaultTextBoxFormFieldString(TextInput? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DefaultTextBoxFormFieldString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DefaultTextBoxFormFieldString { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Text Box Form Field Maximum Length.
  /// </summary>
  public static Int16? GetMaxLength(TextInput? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MaxLength>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMaxLength(TextInput? openXmlElement, Int16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MaxLength>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MaxLength { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Text Box Form Field Formatting.
  /// </summary>
  public static String? GetFormat(TextInput? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Format>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFormat(TextInput? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Format>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Format { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.TextInput? CreateModelElement(TextInput? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TextInput();
      value.TextBoxFormFieldType = GetTextBoxFormFieldType(openXmlElement);
      value.DefaultTextBoxFormFieldString = GetDefaultTextBoxFormFieldString(openXmlElement);
      value.MaxLength = GetMaxLength(openXmlElement);
      value.Format = GetFormat(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TextInput? value)
    where OpenXmlElementType : TextInput, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextBoxFormFieldType(openXmlElement, value?.TextBoxFormFieldType);
      SetDefaultTextBoxFormFieldString(openXmlElement, value?.DefaultTextBoxFormFieldString);
      SetMaxLength(openXmlElement, value?.MaxLength);
      SetFormat(openXmlElement, value?.Format);
      return openXmlElement;
    }
    return default;
  }
}