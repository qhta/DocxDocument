namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public static class SdtPropertiesConverter
{
  private static DocumentModel.Wordprocessing.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetSdtAlias(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtAlias>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSdtAlias(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtAlias>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.SdtAlias { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.LockingKind? GetLock(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Lock>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LockingValues, DocumentModel.Wordprocessing.LockingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLock(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.LockingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Lock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Lock, DocumentFormat.OpenXml.Wordprocessing.LockingValues, DocumentModel.Wordprocessing.LockingKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtPlaceholder? GetSdtPlaceholder(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtPlaceholderConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtPlaceholder(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtPlaceholder? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtPlaceholderConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtPlaceholder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowingPlaceholder(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowingPlaceholder>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetShowingPlaceholder(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ShowingPlaceholder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.ShowingPlaceholder();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.DataBinding? GetDataBinding(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataBinding>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.DataBindingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataBinding(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.DataBinding? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataBinding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.DataBindingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DataBinding>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTemporarySdt(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TemporarySdt>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetTemporarySdt(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TemporarySdt>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.TemporarySdt();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSdtId(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSdtId(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.SdtId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetTag(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tag>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTag(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Tag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.Tag { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.Color3? GetColor(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.Color3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColor(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.Color3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.Color3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtAppearance? GetAppearance(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Appearance>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DocumentModel.Wordprocessing.SdtAppearance>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAppearance(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtAppearance? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Appearance>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.Appearance, DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DocumentModel.Wordprocessing.SdtAppearance>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetWebExtensionLinked(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.WebExtensionLinked>();
    return itemElement != null;
  }
  
  private static void SetWebExtensionLinked(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.WebExtensionLinked>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2013.Word.WebExtensionLinked();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetWebExtensionCreated(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.WebExtensionCreated>();
    return itemElement != null;
  }
  
  private static void SetWebExtensionCreated(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.WebExtensionCreated>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2013.Word.WebExtensionCreated();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentEquation(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentEquation>();
    return itemElement != null;
  }
  
  private static void SetSdtContentEquation(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentEquation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SdtContentEquation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtContentComboBox? GetSdtContentComboBox(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtContentComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentComboBox(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtContentComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtContentComboBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtContentDate? GetSdtContentDate(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDate>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtContentDateConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentDate(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtContentDate? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDate>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtContentDateConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentDate>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtContentDocPartObject? GetSdtContentDocPartObject(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtContentDocPartObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentDocPartObject(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtContentDocPartObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtContentDocPartObjectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartObject>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtContentDocPartList? GetSdtContentDocPartList(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtContentDocPartListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentDocPartList(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtContentDocPartList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtContentDocPartListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentDocPartList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtContentDropDownList? GetSdtContentDropDownList(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtContentDropDownListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentDropDownList(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtContentDropDownList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtContentDropDownListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentDropDownList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentPicture(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentPicture>();
    return itemElement != null;
  }
  
  private static void SetSdtContentPicture(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentPicture>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SdtContentPicture();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentRichText(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentRichText>();
    return itemElement != null;
  }
  
  private static void SetSdtContentRichText(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentRichText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SdtContentRichText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtContentText? GetSdtContentText(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtContentTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentText(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtContentText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtContentTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SdtContentText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentCitation(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentCitation>();
    return itemElement != null;
  }
  
  private static void SetSdtContentCitation(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentCitation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SdtContentCitation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentGroup(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentGroup>();
    return itemElement != null;
  }
  
  private static void SetSdtContentGroup(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentGroup>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SdtContentGroup();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentBibliography(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentBibliography>();
    return itemElement != null;
  }
  
  private static void SetSdtContentBibliography(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtContentBibliography>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.SdtContentBibliography();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetEntityPickerEmpty(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.EntityPickerEmpty>();
    return itemElement != null;
  }
  
  private static void SetEntityPickerEmpty(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.EntityPickerEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Word.EntityPickerEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtContentCheckBox? GetSdtContentCheckBox(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtContentCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentCheckBox(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtContentCheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtContentCheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SdtContentCheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SdtRepeatedSection? GetSdtRepeatedSection(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SdtRepeatedSectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtRepeatedSection(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, DocumentModel.Wordprocessing.SdtRepeatedSection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SdtRepeatedSectionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtRepeatedSectionItem(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSectionItem>();
    return itemElement != null;
  }
  
  private static void SetSdtRepeatedSectionItem(DocumentFormat.OpenXml.Wordprocessing.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSectionItem>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2013.Word.SdtRepeatedSectionItem();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.SdtProperties, new()
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
