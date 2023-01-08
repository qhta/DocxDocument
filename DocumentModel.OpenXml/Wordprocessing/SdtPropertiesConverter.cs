namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public static class SdtPropertiesConverter
{
  public static DocumentModel.Wordprocessing.RunProperties? GetRunProperties(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRunProperties(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.RunProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetSdtAlias(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 2 in property declaring Type is DocumentFormat.OpenXml.Wordprocessing.SdtProperties");
  }
  
  public static void SetSdtAlias(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.LockingKind? GetLock(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Lock>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LockingValues, DocumentModel.Wordprocessing.LockingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLock(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.LockingKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.SdtPlaceholder? GetSdtPlaceholder(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtPlaceholder(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtPlaceholder? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowingPlaceholder(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowingPlaceholder(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.DataBinding? GetDataBinding(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataBinding(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.DataBinding? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetTemporarySdt(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTemporarySdt(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetSdtId(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtId(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetTag(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 2 in property declaring Type is DocumentFormat.OpenXml.Wordprocessing.SdtProperties");
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.Color3? GetColor(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColor(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.Color3? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtAppearance? GetAppearance(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Appearance>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DocumentModel.Wordprocessing.SdtAppearance>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetAppearance(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtAppearance? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetWebExtensionLinked(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWebExtensionLinked(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetWebExtensionCreated(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWebExtensionCreated(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSdtContentEquation(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentEquation(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtContentComboBox? GetSdtContentComboBox(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentComboBox(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtContentComboBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtContentDate? GetSdtContentDate(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentDate(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtContentDate? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtContentDocPartObject? GetSdtContentDocPartObject(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentDocPartObject(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtContentDocPartObject? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtContentDocPartList? GetSdtContentDocPartList(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentDocPartList(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtContentDocPartList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtContentDropDownList? GetSdtContentDropDownList(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentDropDownList(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtContentDropDownList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSdtContentPicture(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentPicture(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSdtContentRichText(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentRichText(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtContentText? GetSdtContentText(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentText(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtContentText? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSdtContentCitation(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentCitation(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSdtContentGroup(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentGroup(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSdtContentBibliography(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentBibliography(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetEntityPickerEmpty(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEntityPickerEmpty(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtContentCheckBox? GetSdtContentCheckBox(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtContentCheckBox(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtContentCheckBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SdtRepeatedSection? GetSdtRepeatedSection(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtRepeatedSection(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtRepeatedSection? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSdtRepeatedSectionItem(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSdtRepeatedSectionItem(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
