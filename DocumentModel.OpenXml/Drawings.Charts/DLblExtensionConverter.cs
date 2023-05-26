namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public static class DLblExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.DLblExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.DLblExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.DLblExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.DataLabelFieldTable? GetDataLabelFieldTable(DXDC.DLblExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.DataLabelFieldTable>();
    if (element != null)
      return DMXDC.DataLabelFieldTableConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelFieldTable(DXDC.DLblExtension openXmlElement, DMDC.DataLabelFieldTable? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.DataLabelFieldTableConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.DataLabelFieldTable>(), value, diffs, objName, propName);
  }
  
  private static void SetDataLabelFieldTable(DXDC.DLblExtension openXmlElement, DMDC.DataLabelFieldTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.DataLabelFieldTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.DataLabelFieldTableConverter.CreateOpenXmlElement<DXO13DC.DataLabelFieldTable>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetExceptionForSave(DXDC.DLblExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO13DC.ExceptionForSave>() != null;
  }
  
  private static bool CmpExceptionForSave(DXDC.DLblExtension openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO13DC.ExceptionForSave>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO13DC.ExceptionForSave", val, value);
    return false;
  }
  
  private static void SetExceptionForSave(DXDC.DLblExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO13DC.ExceptionForSave>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO13DC.ExceptionForSave();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetShowDataLabelsRange(DXDC.DLblExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO13DC.ShowDataLabelsRange>() != null;
  }
  
  private static bool CmpShowDataLabelsRange(DXDC.DLblExtension openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO13DC.ShowDataLabelsRange>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO13DC.ShowDataLabelsRange", val, value);
    return false;
  }
  
  private static void SetShowDataLabelsRange(DXDC.DLblExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO13DC.ShowDataLabelsRange>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO13DC.ShowDataLabelsRange();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.ShapeProperties3? GetShapeProperties(DXDC.DLblExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.ShapeProperties>();
    if (element != null)
      return DMXDC.ShapeProperties3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDC.DLblExtension openXmlElement, DMDC.ShapeProperties3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.ShapeProperties3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXDC.DLblExtension openXmlElement, DMDC.ShapeProperties3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ShapeProperties3Converter.CreateOpenXmlElement<DXO13DC.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDC.Layout3? GetLayout(DXDC.DLblExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.Layout>();
    if (element != null)
      return DMXDC.Layout3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXDC.DLblExtension openXmlElement, DMDC.Layout3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.Layout3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.Layout>(), value, diffs, objName, propName);
  }
  
  private static void SetLayout(DXDC.DLblExtension openXmlElement, DMDC.Layout3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.Layout3Converter.CreateOpenXmlElement<DXO13DC.Layout>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtension? CreateModelElement(DXDC.DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblExtension();
      value.Uri = GetUri(openXmlElement);
      value.DataLabelFieldTable = GetDataLabelFieldTable(openXmlElement);
      value.ExceptionForSave = GetExceptionForSave(openXmlElement);
      value.ShowDataLabelsRange = GetShowDataLabelsRange(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DLblExtension? openXmlElement, DMDC.DLblExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpDataLabelFieldTable(openXmlElement, value.DataLabelFieldTable, diffs, objName, propName))
        ok = false;
      if (!CmpExceptionForSave(openXmlElement, value.ExceptionForSave, diffs, objName, propName))
        ok = false;
      if (!CmpShowDataLabelsRange(openXmlElement, value.ShowDataLabelsRange, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DLblExtension value)
    where OpenXmlElementType: DXDC.DLblExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DLblExtension openXmlElement, DMDC.DLblExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetDataLabelFieldTable(openXmlElement, value?.DataLabelFieldTable);
    SetExceptionForSave(openXmlElement, value?.ExceptionForSave);
    SetShowDataLabelsRange(openXmlElement, value?.ShowDataLabelsRange);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetLayout(openXmlElement, value?.Layout);
  }
}
