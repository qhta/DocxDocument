using DocumentFormat.OpenXml.Vml;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Vml;

/// <summary>
///   Defines the TextBox Class.
/// </summary>
public static class TextBoxConverter
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public static String? GetId(TextBox? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(TextBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  public static String? GetStyle(TextBox? openXmlElement)
  {
    return openXmlElement?.Style?.Value;
  }

  public static void SetStyle(TextBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Style = new StringValue { Value = value };
      else
        openXmlElement.Style = null;
  }

  /// <summary>
  ///   Text Box Inset
  /// </summary>
  public static String? GetInset(TextBox? openXmlElement)
  {
    return openXmlElement?.Inset?.Value;
  }

  public static void SetInset(TextBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Inset = new StringValue { Value = value };
      else
        openXmlElement.Inset = null;
  }

  /// <summary>
  ///   Text Box Single-Click Selection Toggle
  /// </summary>
  public static Boolean? GetSingleClick(TextBox? openXmlElement)
  {
    return openXmlElement?.SingleClick?.Value;
  }

  public static void SetSingleClick(TextBox? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SingleClick = value;
      else
        openXmlElement.SingleClick = null;
  }

  public static TextBoxContent? GetTextBoxContent(TextBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
    if (itemElement != null)
      return TextBoxContentConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextBoxContent(TextBox? openXmlElement, TextBoxContent? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBoxContentConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Vml.TextBox? CreateModelElement(TextBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Vml.TextBox();
      value.Id = GetId(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Inset = GetInset(openXmlElement);
      value.SingleClick = GetSingleClick(openXmlElement);
      value.TextBoxContent = GetTextBoxContent(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Vml.TextBox? value)
    where OpenXmlElementType : TextBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetStyle(openXmlElement, value?.Style);
      SetInset(openXmlElement, value?.Inset);
      SetSingleClick(openXmlElement, value?.SingleClick);
      SetTextBoxContent(openXmlElement, value?.TextBoxContent);
      return openXmlElement;
    }
    return default;
  }
}