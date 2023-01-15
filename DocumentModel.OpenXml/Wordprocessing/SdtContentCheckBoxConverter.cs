using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using CheckBoxSymbolType = DocumentModel.Wordprocessing.CheckBoxSymbolType;
using SdtContentCheckBox = DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SdtContentCheckBox Class.
/// </summary>
public static class SdtContentCheckBoxConverter
{
  /// <summary>
  ///   Checked.
  /// </summary>
  public static OnOffKind? GetChecked(SdtContentCheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Checked>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<OnOffValues, OnOffKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetChecked(SdtContentCheckBox? openXmlElement, OnOffKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Checked>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Checked, OnOffValues, OnOffKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   CheckedState.
  /// </summary>
  public static CheckBoxSymbolType? GetCheckedState(SdtContentCheckBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CheckedState>();
    if (itemElement != null)
      return CheckBoxSymbolTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCheckedState(SdtContentCheckBox? openXmlElement, CheckBoxSymbolType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CheckedState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckBoxSymbolTypeConverter.CreateOpenXmlElement<CheckedState>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   UncheckedState.
  /// </summary>
  public static CheckBoxSymbolType? GetUncheckedState(SdtContentCheckBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<UncheckedState>();
    if (itemElement != null)
      return CheckBoxSymbolTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUncheckedState(SdtContentCheckBox? openXmlElement, CheckBoxSymbolType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<UncheckedState>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckBoxSymbolTypeConverter.CreateOpenXmlElement<UncheckedState>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SdtContentCheckBox? CreateModelElement(SdtContentCheckBox? openXmlElement)
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
    where OpenXmlElementType : SdtContentCheckBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChecked(openXmlElement, value?.Checked);
      SetCheckedState(openXmlElement, value?.CheckedState);
      SetUncheckedState(openXmlElement, value?.UncheckedState);
      return openXmlElement;
    }
    return default;
  }
}