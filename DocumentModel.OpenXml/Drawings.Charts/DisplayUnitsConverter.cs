namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public static class DisplayUnitsConverter
{
  private static Double? GetCustomDisplayUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetCustomDisplayUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.CustomDisplayUnit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.BuiltInUnitKind? GetBuiltInUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DocumentModel.Drawings.Charts.BuiltInUnitKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBuiltInUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement, DocumentModel.Drawings.Charts.BuiltInUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit, DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DocumentModel.Drawings.Charts.BuiltInUnitKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.DisplayUnitsLabel? GetDisplayUnitsLabel(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DisplayUnitsLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDisplayUnitsLabel(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement, DocumentModel.Drawings.Charts.DisplayUnitsLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.DisplayUnitsLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DisplayUnits? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DisplayUnits();
      value.CustomDisplayUnit = GetCustomDisplayUnit(openXmlElement);
      value.BuiltInUnit = GetBuiltInUnit(openXmlElement);
      value.DisplayUnitsLabel = GetDisplayUnitsLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DisplayUnits? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomDisplayUnit(openXmlElement, value?.CustomDisplayUnit);
      SetBuiltInUnit(openXmlElement, value?.BuiltInUnit);
      SetDisplayUnitsLabel(openXmlElement, value?.DisplayUnitsLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
