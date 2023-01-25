namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public static class SdtPropertiesConverter
{
  private static DMW.RunProperties? GetRunProperties(DXW.SdtProperties openXmlElement)
  {
    return DMXW.RunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RunProperties>());
  }
  
  private static bool CmpRunProperties(DXW.SdtProperties openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.SdtAlias>()?.Val?.Value;
  }
  
  private static bool CmpSdtAlias(DXW.SdtProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.SdtAlias>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "SdtAlias", itemElement?.Val?.Value, value);
    return false;
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LockingValues, DMW.LockingKind>(openXmlElement.GetFirstChild<DXW.Lock>()?.Val?.Value);
  }
  
  private static bool CmpLock(DXW.SdtProperties openXmlElement, DMW.LockingKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.LockingValues, DMW.LockingKind>(openXmlElement.GetFirstChild<DXW.Lock>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.SdtPlaceholderConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtPlaceholder>());
  }
  
  private static bool CmpSdtPlaceholder(DXW.SdtProperties openXmlElement, DMW.SdtPlaceholder? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtPlaceholderConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtPlaceholder>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.ShowingPlaceholder>()?.Val?.Value;
  }
  
  private static bool CmpShowingPlaceholder(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.ShowingPlaceholder>()?.Val?.Value == value;
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
    return DMXW.DataBindingConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DataBinding>());
  }
  
  private static bool CmpDataBinding(DXW.SdtProperties openXmlElement, DMW.DataBinding? value, DiffList? diffs, string? objName)
  {
    return DMXW.DataBindingConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DataBinding>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.TemporarySdt>()?.Val?.Value;
  }
  
  private static bool CmpTemporarySdt(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.TemporarySdt>()?.Val?.Value == value;
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
    return openXmlElement?.GetFirstChild<DXW.SdtId>()?.Val?.Value;
  }
  
  private static bool CmpSdtId(DXW.SdtProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.SdtId>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "DXW.SdtId", itemElement?.Val?.Value, value);
    return false;
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
    return openXmlElement.GetFirstChild<DXW.Tag>()?.Val?.Value;
  }
  
  private static bool CmpTag(DXW.SdtProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Tag>();
    if (itemElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Tag", itemElement?.Val?.Value, value);
    return false;
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
    return DMXW.Color3Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013W.Color>());
  }
  
  private static bool CmpColor(DXW.SdtProperties openXmlElement, DMW.Color3? value, DiffList? diffs, string? objName)
  {
    return DMXW.Color3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013W.Color>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DMW.SdtAppearance>(openXmlElement.GetFirstChild<DXO2013W.Appearance>()?.Val?.Value);
  }
  
  private static bool CmpAppearance(DXW.SdtProperties openXmlElement, DMW.SdtAppearance? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DMW.SdtAppearance>(openXmlElement.GetFirstChild<DXO2013W.Appearance>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXO2013W.WebExtensionLinked>() != null;
  }
  
  private static bool CmpWebExtensionLinked(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2013W.WebExtensionLinked>() != null == value;
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
    return openXmlElement.GetFirstChild<DXO2013W.WebExtensionCreated>() != null;
  }
  
  private static bool CmpWebExtensionCreated(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2013W.WebExtensionCreated>() != null == value;
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
    return openXmlElement.GetFirstChild<DXW.SdtContentEquation>() != null;
  }
  
  private static bool CmpSdtContentEquation(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SdtContentEquation>() != null == value;
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
    return DMXW.SdtContentComboBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtContentComboBox>());
  }
  
  private static bool CmpSdtContentComboBox(DXW.SdtProperties openXmlElement, DMW.SdtContentComboBox? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentComboBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.SdtContentDateConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtContentDate>());
  }
  
  private static bool CmpSdtContentDate(DXW.SdtProperties openXmlElement, DMW.SdtContentDate? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentDateConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentDate>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.SdtContentDocPartObjectConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtContentDocPartObject>());
  }
  
  private static bool CmpSdtContentDocPartObject(DXW.SdtProperties openXmlElement, DMW.SdtContentDocPartObject? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentDocPartObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentDocPartObject>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.SdtContentDocPartListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtContentDocPartList>());
  }
  
  private static bool CmpSdtContentDocPartList(DXW.SdtProperties openXmlElement, DMW.SdtContentDocPartList? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentDocPartListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentDocPartList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.SdtContentDropDownListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtContentDropDownList>());
  }
  
  private static bool CmpSdtContentDropDownList(DXW.SdtProperties openXmlElement, DMW.SdtContentDropDownList? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentDropDownListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentDropDownList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.SdtContentPicture>() != null;
  }
  
  private static bool CmpSdtContentPicture(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SdtContentPicture>() != null == value;
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
    return openXmlElement.GetFirstChild<DXW.SdtContentRichText>() != null;
  }
  
  private static bool CmpSdtContentRichText(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SdtContentRichText>() != null == value;
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
    return DMXW.SdtContentTextConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.SdtContentText>());
  }
  
  private static bool CmpSdtContentText(DXW.SdtProperties openXmlElement, DMW.SdtContentText? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentTextConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.SdtContentText>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXW.SdtContentCitation>() != null;
  }
  
  private static bool CmpSdtContentCitation(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SdtContentCitation>() != null == value;
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
    return openXmlElement.GetFirstChild<DXW.SdtContentGroup>() != null;
  }
  
  private static bool CmpSdtContentGroup(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SdtContentGroup>() != null == value;
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
    return openXmlElement.GetFirstChild<DXW.SdtContentBibliography>() != null;
  }
  
  private static bool CmpSdtContentBibliography(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXW.SdtContentBibliography>() != null == value;
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
    return openXmlElement.GetFirstChild<DXO2010W.EntityPickerEmpty>() != null;
  }
  
  private static bool CmpEntityPickerEmpty(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2010W.EntityPickerEmpty>() != null == value;
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
    return DMXW.SdtContentCheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010W.SdtContentCheckBox>());
  }
  
  private static bool CmpSdtContentCheckBox(DXW.SdtProperties openXmlElement, DMW.SdtContentCheckBox? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtContentCheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.SdtContentCheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXW.SdtRepeatedSectionConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013W.SdtRepeatedSection>());
  }
  
  private static bool CmpSdtRepeatedSection(DXW.SdtProperties openXmlElement, DMW.SdtRepeatedSection? value, DiffList? diffs, string? objName)
  {
    return DMXW.SdtRepeatedSectionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013W.SdtRepeatedSection>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXO2013W.SdtRepeatedSectionItem>() != null;
  }
  
  private static bool CmpSdtRepeatedSectionItem(DXW.SdtProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2013W.SdtRepeatedSectionItem>() != null == value;
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
  
  public static bool CompareModelElement(DXW.SdtProperties? openXmlElement, DMW.SdtProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName))
        ok = false;
      if (!CmpSdtAlias(openXmlElement, value.SdtAlias, diffs, objName))
        ok = false;
      if (!CmpLock(openXmlElement, value.Lock, diffs, objName))
        ok = false;
      if (!CmpSdtPlaceholder(openXmlElement, value.SdtPlaceholder, diffs, objName))
        ok = false;
      if (!CmpShowingPlaceholder(openXmlElement, value.ShowingPlaceholder, diffs, objName))
        ok = false;
      if (!CmpDataBinding(openXmlElement, value.DataBinding, diffs, objName))
        ok = false;
      if (!CmpTemporarySdt(openXmlElement, value.TemporarySdt, diffs, objName))
        ok = false;
      if (!CmpSdtId(openXmlElement, value.SdtId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpAppearance(openXmlElement, value.Appearance, diffs, objName))
        ok = false;
      if (!CmpWebExtensionLinked(openXmlElement, value.WebExtensionLinked, diffs, objName))
        ok = false;
      if (!CmpWebExtensionCreated(openXmlElement, value.WebExtensionCreated, diffs, objName))
        ok = false;
      if (!CmpSdtContentEquation(openXmlElement, value.SdtContentEquation, diffs, objName))
        ok = false;
      if (!CmpSdtContentComboBox(openXmlElement, value.SdtContentComboBox, diffs, objName))
        ok = false;
      if (!CmpSdtContentDate(openXmlElement, value.SdtContentDate, diffs, objName))
        ok = false;
      if (!CmpSdtContentDocPartObject(openXmlElement, value.SdtContentDocPartObject, diffs, objName))
        ok = false;
      if (!CmpSdtContentDocPartList(openXmlElement, value.SdtContentDocPartList, diffs, objName))
        ok = false;
      if (!CmpSdtContentDropDownList(openXmlElement, value.SdtContentDropDownList, diffs, objName))
        ok = false;
      if (!CmpSdtContentPicture(openXmlElement, value.SdtContentPicture, diffs, objName))
        ok = false;
      if (!CmpSdtContentRichText(openXmlElement, value.SdtContentRichText, diffs, objName))
        ok = false;
      if (!CmpSdtContentText(openXmlElement, value.SdtContentText, diffs, objName))
        ok = false;
      if (!CmpSdtContentCitation(openXmlElement, value.SdtContentCitation, diffs, objName))
        ok = false;
      if (!CmpSdtContentGroup(openXmlElement, value.SdtContentGroup, diffs, objName))
        ok = false;
      if (!CmpSdtContentBibliography(openXmlElement, value.SdtContentBibliography, diffs, objName))
        ok = false;
      if (!CmpEntityPickerEmpty(openXmlElement, value.EntityPickerEmpty, diffs, objName))
        ok = false;
      if (!CmpSdtContentCheckBox(openXmlElement, value.SdtContentCheckBox, diffs, objName))
        ok = false;
      if (!CmpSdtRepeatedSection(openXmlElement, value.SdtRepeatedSection, diffs, objName))
        ok = false;
      if (!CmpSdtRepeatedSectionItem(openXmlElement, value.SdtRepeatedSectionItem, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
