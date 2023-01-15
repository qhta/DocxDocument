using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Office2013.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Color = DocumentFormat.OpenXml.Office2013.Word.Color;
using DataBinding = DocumentModel.Wordprocessing.DataBinding;
using RunProperties = DocumentModel.Wordprocessing.RunProperties;
using SdtAppearance = DocumentModel.Wordprocessing.SdtAppearance;
using SdtContentCheckBox = DocumentModel.Wordprocessing.SdtContentCheckBox;
using SdtContentComboBox = DocumentModel.Wordprocessing.SdtContentComboBox;
using SdtContentDate = DocumentModel.Wordprocessing.SdtContentDate;
using SdtContentDocPartList = DocumentModel.Wordprocessing.SdtContentDocPartList;
using SdtContentDocPartObject = DocumentModel.Wordprocessing.SdtContentDocPartObject;
using SdtContentDropDownList = DocumentModel.Wordprocessing.SdtContentDropDownList;
using SdtContentText = DocumentModel.Wordprocessing.SdtContentText;
using SdtPlaceholder = DocumentModel.Wordprocessing.SdtPlaceholder;
using SdtProperties = DocumentFormat.OpenXml.Wordprocessing.SdtProperties;
using SdtRepeatedSection = DocumentModel.Wordprocessing.SdtRepeatedSection;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Structured Document Tag Properties.
/// </summary>
public static class SdtPropertiesConverter
{
  public static RunProperties? GetRunProperties(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunProperties(SdtProperties? openXmlElement, RunProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetSdtAlias(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SdtAlias>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSdtAlias(SdtProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtAlias>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SdtAlias { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LockingKind? GetLock(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Lock>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LockingValues, LockingKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLock(SdtProperties? openXmlElement, LockingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Lock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Lock, LockingValues, LockingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtPlaceholder? GetSdtPlaceholder(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder>();
    if (itemElement != null)
      return SdtPlaceholderConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtPlaceholder(SdtProperties? openXmlElement, SdtPlaceholder? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtPlaceholderConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetShowingPlaceholder(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowingPlaceholder>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowingPlaceholder(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowingPlaceholder>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowingPlaceholder();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DataBinding? GetDataBinding(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataBinding>();
    if (itemElement != null)
      return DataBindingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataBinding(SdtProperties? openXmlElement, DataBinding? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataBinding>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataBindingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DataBinding>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetTemporarySdt(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TemporarySdt>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetTemporarySdt(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<TemporarySdt>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new TemporarySdt();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetSdtId(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SdtId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSdtId(SdtProperties? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SdtId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static String? GetTag(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Tag>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTag(SdtProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Tag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Tag { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Color3? GetColor(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Color>();
    if (itemElement != null)
      return Color3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColor(SdtProperties? openXmlElement, Color3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Color3Converter.CreateOpenXmlElement<Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtAppearance? GetAppearance(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Appearance>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, SdtAppearance>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAppearance(SdtProperties? openXmlElement, SdtAppearance? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Appearance>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Appearance, DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, SdtAppearance>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetWebExtensionLinked(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WebExtensionLinked>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWebExtensionLinked(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WebExtensionLinked>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WebExtensionLinked();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetWebExtensionCreated(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WebExtensionCreated>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWebExtensionCreated(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<WebExtensionCreated>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new WebExtensionCreated();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSdtContentEquation(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtContentEquation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSdtContentEquation(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SdtContentEquation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SdtContentEquation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtContentComboBox? GetSdtContentComboBox(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox>();
    if (itemElement != null)
      return SdtContentComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtContentComboBox(SdtProperties? openXmlElement, SdtContentComboBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtContentComboBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtContentDate? GetSdtContentDate(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDate>();
    if (itemElement != null)
      return SdtContentDateConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtContentDate(SdtProperties? openXmlElement, SdtContentDate? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDate>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtContentDateConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentDate>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtContentDocPartObject? GetSdtContentDocPartObject(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject>();
    if (itemElement != null)
      return SdtContentDocPartObjectConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtContentDocPartObject(SdtProperties? openXmlElement, SdtContentDocPartObject? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtContentDocPartObjectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtContentDocPartList? GetSdtContentDocPartList(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList>();
    if (itemElement != null)
      return SdtContentDocPartListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtContentDocPartList(SdtProperties? openXmlElement, SdtContentDocPartList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtContentDocPartListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtContentDropDownList? GetSdtContentDropDownList(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList>();
    if (itemElement != null)
      return SdtContentDropDownListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtContentDropDownList(SdtProperties? openXmlElement, SdtContentDropDownList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtContentDropDownListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSdtContentPicture(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtContentPicture>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSdtContentPicture(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SdtContentPicture>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SdtContentPicture();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSdtContentRichText(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtContentRichText>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSdtContentRichText(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SdtContentRichText>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SdtContentRichText();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtContentText? GetSdtContentText(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentText>();
    if (itemElement != null)
      return SdtContentTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtContentText(SdtProperties? openXmlElement, SdtContentText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtContentTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSdtContentCitation(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtContentCitation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSdtContentCitation(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SdtContentCitation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SdtContentCitation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSdtContentGroup(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtContentGroup>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSdtContentGroup(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SdtContentGroup>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SdtContentGroup();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSdtContentBibliography(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtContentBibliography>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSdtContentBibliography(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SdtContentBibliography>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SdtContentBibliography();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetEntityPickerEmpty(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EntityPickerEmpty>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetEntityPickerEmpty(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<EntityPickerEmpty>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new EntityPickerEmpty();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtContentCheckBox? GetSdtContentCheckBox(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox>();
    if (itemElement != null)
      return SdtContentCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtContentCheckBox(SdtProperties? openXmlElement, SdtContentCheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtContentCheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SdtRepeatedSection? GetSdtRepeatedSection(SdtProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection>();
    if (itemElement != null)
      return SdtRepeatedSectionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSdtRepeatedSection(SdtProperties? openXmlElement, SdtRepeatedSection? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtRepeatedSectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetSdtRepeatedSectionItem(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SdtRepeatedSectionItem>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetSdtRepeatedSectionItem(SdtProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<SdtRepeatedSectionItem>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new SdtRepeatedSectionItem();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SdtProperties? CreateModelElement(SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtProperties();
      value.RunProperties = GetRunProperties(openXmlElement);
      value.SdtAlias = GetSdtAlias(openXmlElement);
      value.Lock = GetLock(openXmlElement);
      value.SdtPlaceholder = GetSdtPlaceholder(openXmlElement);
      value.ShowingPlaceholder = GetShowingPlaceholder(openXmlElement);
      value.DataBinding = GetDataBinding(openXmlElement);
      value.TemporarySdt = GetTemporarySdt(openXmlElement);
      value.SdtId = GetSdtId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.Appearance = GetAppearance(openXmlElement);
      value.WebExtensionLinked = GetWebExtensionLinked(openXmlElement);
      value.WebExtensionCreated = GetWebExtensionCreated(openXmlElement);
      value.SdtContentEquation = GetSdtContentEquation(openXmlElement);
      value.SdtContentComboBox = GetSdtContentComboBox(openXmlElement);
      value.SdtContentDate = GetSdtContentDate(openXmlElement);
      value.SdtContentDocPartObject = GetSdtContentDocPartObject(openXmlElement);
      value.SdtContentDocPartList = GetSdtContentDocPartList(openXmlElement);
      value.SdtContentDropDownList = GetSdtContentDropDownList(openXmlElement);
      value.SdtContentPicture = GetSdtContentPicture(openXmlElement);
      value.SdtContentRichText = GetSdtContentRichText(openXmlElement);
      value.SdtContentText = GetSdtContentText(openXmlElement);
      value.SdtContentCitation = GetSdtContentCitation(openXmlElement);
      value.SdtContentGroup = GetSdtContentGroup(openXmlElement);
      value.SdtContentBibliography = GetSdtContentBibliography(openXmlElement);
      value.EntityPickerEmpty = GetEntityPickerEmpty(openXmlElement);
      value.SdtContentCheckBox = GetSdtContentCheckBox(openXmlElement);
      value.SdtRepeatedSection = GetSdtRepeatedSection(openXmlElement);
      value.SdtRepeatedSectionItem = GetSdtRepeatedSectionItem(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtProperties? value)
    where OpenXmlElementType : SdtProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetSdtAlias(openXmlElement, value?.SdtAlias);
      SetLock(openXmlElement, value?.Lock);
      SetSdtPlaceholder(openXmlElement, value?.SdtPlaceholder);
      SetShowingPlaceholder(openXmlElement, value?.ShowingPlaceholder);
      SetDataBinding(openXmlElement, value?.DataBinding);
      SetTemporarySdt(openXmlElement, value?.TemporarySdt);
      SetSdtId(openXmlElement, value?.SdtId);
      SetTag(openXmlElement, value?.Tag);
      SetColor(openXmlElement, value?.Color);
      SetAppearance(openXmlElement, value?.Appearance);
      SetWebExtensionLinked(openXmlElement, value?.WebExtensionLinked);
      SetWebExtensionCreated(openXmlElement, value?.WebExtensionCreated);
      SetSdtContentEquation(openXmlElement, value?.SdtContentEquation);
      SetSdtContentComboBox(openXmlElement, value?.SdtContentComboBox);
      SetSdtContentDate(openXmlElement, value?.SdtContentDate);
      SetSdtContentDocPartObject(openXmlElement, value?.SdtContentDocPartObject);
      SetSdtContentDocPartList(openXmlElement, value?.SdtContentDocPartList);
      SetSdtContentDropDownList(openXmlElement, value?.SdtContentDropDownList);
      SetSdtContentPicture(openXmlElement, value?.SdtContentPicture);
      SetSdtContentRichText(openXmlElement, value?.SdtContentRichText);
      SetSdtContentText(openXmlElement, value?.SdtContentText);
      SetSdtContentCitation(openXmlElement, value?.SdtContentCitation);
      SetSdtContentGroup(openXmlElement, value?.SdtContentGroup);
      SetSdtContentBibliography(openXmlElement, value?.SdtContentBibliography);
      SetEntityPickerEmpty(openXmlElement, value?.EntityPickerEmpty);
      SetSdtContentCheckBox(openXmlElement, value?.SdtContentCheckBox);
      SetSdtRepeatedSection(openXmlElement, value?.SdtRepeatedSection);
      SetSdtRepeatedSectionItem(openXmlElement, value?.SdtRepeatedSectionItem);
      return openXmlElement;
    }
    return default;
  }
}