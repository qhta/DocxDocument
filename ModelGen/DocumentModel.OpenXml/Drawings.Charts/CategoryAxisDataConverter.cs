namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public static class CategoryAxisDataConverter
{
  private static DMDrawsCharts.MultiLevelStringReference? GetMultiLevelStringReference(DXDrawCharts.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.MultiLevelStringReference>();
    if (element != null)
      return DMXDrawsCharts.MultiLevelStringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMultiLevelStringReference(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.MultiLevelStringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.MultiLevelStringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.MultiLevelStringReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMultiLevelStringReference(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.MultiLevelStringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.MultiLevelStringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.MultiLevelStringReferenceConverter.CreateOpenXmlElement<DXDrawCharts.MultiLevelStringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.NumberReference? GetNumberReference(DXDrawCharts.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.NumberReference>();
    if (element != null)
      return DMXDrawsCharts.NumberReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberReference(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.NumberReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberReference(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.NumberReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberReferenceConverter.CreateOpenXmlElement<DXDrawCharts.NumberReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.NumberLiteral? GetNumberLiteral(DXDrawCharts.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.NumberLiteral>();
    if (element != null)
      return DMXDrawsCharts.NumberLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberLiteral(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.NumberLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.NumberLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.NumberLiteral>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumberLiteral(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.NumberLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumberLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.NumberLiteralConverter.CreateOpenXmlElement<DXDrawCharts.NumberLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.StringReference? GetStringReference(DXDrawCharts.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>();
    if (element != null)
      return DMXDrawsCharts.StringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringReference(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.StringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StringReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringReference(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringReferenceConverter.CreateOpenXmlElement<DXDrawCharts.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.StringLiteral? GetStringLiteral(DXDrawCharts.CategoryAxisData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (element != null)
      return DMXDrawsCharts.StringLiteralConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringLiteral(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.StringLiteral? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StringLiteralConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDrawCharts.StringLiteral>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringLiteral(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.StringLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringLiteralConverter.CreateOpenXmlElement<DXDrawCharts.StringLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryAxisData? CreateModelElement(DXDrawCharts.CategoryAxisData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryAxisData();
      value.MultiLevelStringReference = GetMultiLevelStringReference(openXmlElement);
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      value.StringReference = GetStringReference(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.CategoryAxisData? openXmlElement, DMDrawsCharts.CategoryAxisData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMultiLevelStringReference(openXmlElement, value.MultiLevelStringReference, diffs, objName))
        ok = false;
      if (!CmpNumberReference(openXmlElement, value.NumberReference, diffs, objName))
        ok = false;
      if (!CmpNumberLiteral(openXmlElement, value.NumberLiteral, diffs, objName))
        ok = false;
      if (!CmpStringReference(openXmlElement, value.StringReference, diffs, objName))
        ok = false;
      if (!CmpStringLiteral(openXmlElement, value.StringLiteral, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CategoryAxisData value)
    where OpenXmlElementType: DXDrawCharts.CategoryAxisData, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.CategoryAxisData openXmlElement, DMDrawsCharts.CategoryAxisData value)
  {
    SetMultiLevelStringReference(openXmlElement, value?.MultiLevelStringReference);
    SetNumberReference(openXmlElement, value?.NumberReference);
    SetNumberLiteral(openXmlElement, value?.NumberLiteral);
    SetStringReference(openXmlElement, value?.StringReference);
    SetStringLiteral(openXmlElement, value?.StringLiteral);
  }
}
