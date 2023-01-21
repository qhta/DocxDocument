namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public static class SdtPropertiesConverter
{
  private static DMW.RunProperties? GetRunProperties(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DXW.SdtProperties openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement<DXW.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetSdtAlias(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtAlias>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSdtAlias(DXW.SdtProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtAlias>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.SdtAlias { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.LockingKind? GetLock(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Lock>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LockingValues, DMW.LockingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLock(DXW.SdtProperties openXmlElement, DMW.LockingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Lock>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Lock, DocumentFormat.OpenXml.Wordprocessing.LockingValues, DMW.LockingKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtPlaceholder? GetSdtPlaceholder(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtPlaceholder>();
    if (itemElement != null)
      return DMXW.SdtPlaceholderConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtPlaceholder(DXW.SdtProperties openXmlElement, DMW.SdtPlaceholder? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtPlaceholder>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtPlaceholderConverter.CreateOpenXmlElement<DXW.SdtPlaceholder>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowingPlaceholder(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ShowingPlaceholder>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetShowingPlaceholder(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.ShowingPlaceholder>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.ShowingPlaceholder();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DataBinding? GetDataBinding(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DataBinding>();
    if (itemElement != null)
      return DMXW.DataBindingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataBinding(DXW.SdtProperties openXmlElement, DMW.DataBinding? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DataBinding>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DataBindingConverter.CreateOpenXmlElement<DXW.DataBinding>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTemporarySdt(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TemporarySdt>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetTemporarySdt(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.TemporarySdt>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.TemporarySdt();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetSdtId(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetSdtId(DXW.SdtProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.SdtId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetTag(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Tag>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetTag(DXW.SdtProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Tag>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXW.Tag { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.Color3? GetColor(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013W.Color>();
    if (itemElement != null)
      return DMXW.Color3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColor(DXW.SdtProperties openXmlElement, DMW.Color3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.Color>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.Color3Converter.CreateOpenXmlElement<DXO2013W.Color>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtAppearance? GetAppearance(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.Appearance>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DMW.SdtAppearance>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAppearance(DXW.SdtProperties openXmlElement, DMW.SdtAppearance? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.Appearance>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXO2013W.Appearance, DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DMW.SdtAppearance>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetWebExtensionLinked(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.WebExtensionLinked>();
    return itemElement != null;
  }
  
  private static void SetWebExtensionLinked(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013W.WebExtensionLinked>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013W.WebExtensionLinked();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetWebExtensionCreated(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.WebExtensionCreated>();
    return itemElement != null;
  }
  
  private static void SetWebExtensionCreated(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013W.WebExtensionCreated>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013W.WebExtensionCreated();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentEquation(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentEquation>();
    return itemElement != null;
  }
  
  private static void SetSdtContentEquation(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentEquation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SdtContentEquation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtContentComboBox? GetSdtContentComboBox(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtContentComboBox>();
    if (itemElement != null)
      return DMXW.SdtContentComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentComboBox(DXW.SdtProperties openXmlElement, DMW.SdtContentComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentComboBoxConverter.CreateOpenXmlElement<DXW.SdtContentComboBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtContentDate? GetSdtContentDate(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtContentDate>();
    if (itemElement != null)
      return DMXW.SdtContentDateConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentDate(DXW.SdtProperties openXmlElement, DMW.SdtContentDate? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentDate>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentDateConverter.CreateOpenXmlElement<DXW.SdtContentDate>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtContentDocPartObject? GetSdtContentDocPartObject(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtContentDocPartObject>();
    if (itemElement != null)
      return DMXW.SdtContentDocPartObjectConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentDocPartObject(DXW.SdtProperties openXmlElement, DMW.SdtContentDocPartObject? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentDocPartObject>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentDocPartObjectConverter.CreateOpenXmlElement<DXW.SdtContentDocPartObject>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtContentDocPartList? GetSdtContentDocPartList(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtContentDocPartList>();
    if (itemElement != null)
      return DMXW.SdtContentDocPartListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentDocPartList(DXW.SdtProperties openXmlElement, DMW.SdtContentDocPartList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentDocPartList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentDocPartListConverter.CreateOpenXmlElement<DXW.SdtContentDocPartList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtContentDropDownList? GetSdtContentDropDownList(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtContentDropDownList>();
    if (itemElement != null)
      return DMXW.SdtContentDropDownListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentDropDownList(DXW.SdtProperties openXmlElement, DMW.SdtContentDropDownList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentDropDownList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentDropDownListConverter.CreateOpenXmlElement<DXW.SdtContentDropDownList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentPicture(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentPicture>();
    return itemElement != null;
  }
  
  private static void SetSdtContentPicture(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentPicture>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SdtContentPicture();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentRichText(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentRichText>();
    return itemElement != null;
  }
  
  private static void SetSdtContentRichText(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentRichText>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SdtContentRichText();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtContentText? GetSdtContentText(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtContentText>();
    if (itemElement != null)
      return DMXW.SdtContentTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentText(DXW.SdtProperties openXmlElement, DMW.SdtContentText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentTextConverter.CreateOpenXmlElement<DXW.SdtContentText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentCitation(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentCitation>();
    return itemElement != null;
  }
  
  private static void SetSdtContentCitation(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentCitation>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SdtContentCitation();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentGroup(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentGroup>();
    return itemElement != null;
  }
  
  private static void SetSdtContentGroup(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentGroup>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SdtContentGroup();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtContentBibliography(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentBibliography>();
    return itemElement != null;
  }
  
  private static void SetSdtContentBibliography(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.SdtContentBibliography>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.SdtContentBibliography();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetEntityPickerEmpty(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.EntityPickerEmpty>();
    return itemElement != null;
  }
  
  private static void SetEntityPickerEmpty(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010W.EntityPickerEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010W.EntityPickerEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtContentCheckBox? GetSdtContentCheckBox(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010W.SdtContentCheckBox>();
    if (itemElement != null)
      return DMXW.SdtContentCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtContentCheckBox(DXW.SdtProperties openXmlElement, DMW.SdtContentCheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.SdtContentCheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtContentCheckBoxConverter.CreateOpenXmlElement<DXO2010W.SdtContentCheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.SdtRepeatedSection? GetSdtRepeatedSection(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013W.SdtRepeatedSection>();
    if (itemElement != null)
      return DMXW.SdtRepeatedSectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSdtRepeatedSection(DXW.SdtProperties openXmlElement, DMW.SdtRepeatedSection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.SdtRepeatedSection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.SdtRepeatedSectionConverter.CreateOpenXmlElement<DXO2013W.SdtRepeatedSection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetSdtRepeatedSectionItem(DXW.SdtProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013W.SdtRepeatedSectionItem>();
    return itemElement != null;
  }
  
  private static void SetSdtRepeatedSectionItem(DXW.SdtProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013W.SdtRepeatedSectionItem>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013W.SdtRepeatedSectionItem();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SdtProperties? CreateModelElement(DXW.SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtProperties? value)
    where OpenXmlElementType: DXW.SdtProperties, new()
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
