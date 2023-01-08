namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public static class DisplayUnitsConverter
{
  public static Double? GetCustomDisplayUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomDisplayUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.BuiltInUnitKind? GetBuiltInUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DocumentModel.Drawings.Charts.BuiltInUnitKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBuiltInUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement, DocumentModel.Drawings.Charts.BuiltInUnitKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.DisplayUnitsLabel? GetDisplayUnitsLabel(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDisplayUnitsLabel(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement, DocumentModel.Drawings.Charts.DisplayUnitsLabel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
