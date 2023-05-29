namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Custom File Property.
/// </summary>
public static class CustomDocumentPropertyConverter
{
  /// <summary>
  /// Format ID
  /// </summary>
  private static String? GetFormatId(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FormatId);
  }
  
  private static bool CmpFormatId(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FormatId, value, diffs, objName, "FormatId");
  }
  
  private static void SetFormatId(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    openXmlElement.FormatId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Property ID
  /// </summary>
  private static Int32? GetPropertyId(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement?.PropertyId?.Value;
  }
  
  private static bool CmpPropertyId(DXCustProps.CustomDocumentProperty openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.PropertyId?.Value == value) return true;
    diffs?.Add(objName, "PropertyId", openXmlElement?.PropertyId?.Value, value);
    return false;
  }
  
  private static void SetPropertyId(DXCustProps.CustomDocumentProperty openXmlElement, Int32? value)
  {
    openXmlElement.PropertyId = value;
  }
  
  /// <summary>
  /// Custom File Property Name
  /// </summary>
  private static String? GetName(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Bookmark Link Target
  /// </summary>
  private static String? GetLinkTarget(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LinkTarget);
  }
  
  private static bool CmpLinkTarget(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LinkTarget, value, diffs, objName, "LinkTarget");
  }
  
  private static void SetLinkTarget(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    openXmlElement.LinkTarget = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Vector.
  /// </summary>
  private static DM.VectorVariant? GetVTVector(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVT.VTVector>();
    if (element != null)
      return ObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVTVector(DXCustProps.CustomDocumentProperty openXmlElement, DM.VectorVariant? value, DiffList? diffs, string? objName)
  {
    return ObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVT.VTVector>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVTVector(DXCustProps.CustomDocumentProperty openXmlElement, DM.VectorVariant? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTVector>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.VectorVariantConverter.CreateOpenXmlElement<DXVT.VTVector>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Array.
  /// </summary>
  private static DM.ArrayVariant? GetVTArray(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVT.VTArray>();
    if (element != null)
      return ObjectConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVTArray(DXCustProps.CustomDocumentProperty openXmlElement, DM.ArrayVariant? value, DiffList? diffs, string? objName)
  {
    return ObjectConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVT.VTArray>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVTArray(DXCustProps.CustomDocumentProperty openXmlElement, DM.ArrayVariant? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTArray>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ArrayVariantConverter.CreateOpenXmlElement<DXVT.VTArray>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Binary Blob.
  /// </summary>
  private static String? GetVTBlob(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTBlob>()?.Text;
  }
  
  private static bool CmpVTBlob(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTBlob>()?.Text == value;
  }
  
  private static void SetVTBlob(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTBlob>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTBlob { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Binary Blob Object.
  /// </summary>
  private static String? GetVTOBlob(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTOBlob>()?.Text;
  }
  
  private static bool CmpVTOBlob(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTOBlob>()?.Text == value;
  }
  
  private static void SetVTOBlob(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTOBlob>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTOBlob { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Empty.
  /// </summary>
  private static Boolean? GetVTEmpty(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVT.VTEmpty>() != null;
  }
  
  private static bool CmpVTEmpty(DXCustProps.CustomDocumentProperty openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXVT.VTEmpty>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXVT.VTEmpty", val, value);
    return false;
  }
  
  private static void SetVTEmpty(DXCustProps.CustomDocumentProperty openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXVT.VTEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXVT.VTEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Null.
  /// </summary>
  private static Boolean? GetVTNull(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXVT.VTNull>() != null;
  }
  
  private static bool CmpVTNull(DXCustProps.CustomDocumentProperty openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXVT.VTNull>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXVT.VTNull", val, value);
    return false;
  }
  
  private static void SetVTNull(DXCustProps.CustomDocumentProperty openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXVT.VTNull>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXVT.VTNull();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 1-Byte Signed Integer.
  /// </summary>
  private static String? GetVTByte(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTByte>()?.Text;
  }
  
  private static bool CmpVTByte(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTByte>()?.Text == value;
  }
  
  private static void SetVTByte(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTByte>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTByte { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 2-Byte Signed Integer.
  /// </summary>
  private static String? GetVTShort(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTShort>()?.Text;
  }
  
  private static bool CmpVTShort(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTShort>()?.Text == value;
  }
  
  private static void SetVTShort(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTShort>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTShort { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 4-Byte Signed Integer.
  /// </summary>
  private static String? GetVTInt32(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTInt32>()?.Text;
  }
  
  private static bool CmpVTInt32(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTInt32>()?.Text == value;
  }
  
  private static void SetVTInt32(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTInt32>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTInt32 { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 8-Byte Signed Integer.
  /// </summary>
  private static String? GetVTInt64(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTInt64>()?.Text;
  }
  
  private static bool CmpVTInt64(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTInt64>()?.Text == value;
  }
  
  private static void SetVTInt64(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTInt64>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTInt64 { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Integer.
  /// </summary>
  private static String? GetVTInteger(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTInteger>()?.Text;
  }
  
  private static bool CmpVTInteger(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTInteger>()?.Text == value;
  }
  
  private static void SetVTInteger(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTInteger>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTInteger { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 1-Byte Unsigned Integer.
  /// </summary>
  private static String? GetVTUnsignedByte(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedByte>()?.Text;
  }
  
  private static bool CmpVTUnsignedByte(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedByte>()?.Text == value;
  }
  
  private static void SetVTUnsignedByte(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTUnsignedByte>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTUnsignedByte { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 2-Byte Unsigned Integer.
  /// </summary>
  private static String? GetVTUnsignedShort(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedShort>()?.Text;
  }
  
  private static bool CmpVTUnsignedShort(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedShort>()?.Text == value;
  }
  
  private static void SetVTUnsignedShort(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTUnsignedShort>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTUnsignedShort { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 4-Byte Unsigned Integer.
  /// </summary>
  private static String? GetVTUnsignedInt32(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedInt32>()?.Text;
  }
  
  private static bool CmpVTUnsignedInt32(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedInt32>()?.Text == value;
  }
  
  private static void SetVTUnsignedInt32(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTUnsignedInt32>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTUnsignedInt32 { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 8-Byte Unsigned Integer.
  /// </summary>
  private static String? GetVTUnsignedInt64(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedInt64>()?.Text;
  }
  
  private static bool CmpVTUnsignedInt64(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedInt64>()?.Text == value;
  }
  
  private static void SetVTUnsignedInt64(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTUnsignedInt64>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTUnsignedInt64 { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Unsigned Integer.
  /// </summary>
  private static String? GetVTUnsignedInteger(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedInteger>()?.Text;
  }
  
  private static bool CmpVTUnsignedInteger(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTUnsignedInteger>()?.Text == value;
  }
  
  private static void SetVTUnsignedInteger(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTUnsignedInteger>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTUnsignedInteger { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 4-Byte Real Number.
  /// </summary>
  private static String? GetVTFloat(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTFloat>()?.Text;
  }
  
  private static bool CmpVTFloat(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTFloat>()?.Text == value;
  }
  
  private static void SetVTFloat(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTFloat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTFloat { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// 8-Byte Real Number.
  /// </summary>
  private static String? GetVTDouble(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTDouble>()?.Text;
  }
  
  private static bool CmpVTDouble(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTDouble>()?.Text == value;
  }
  
  private static void SetVTDouble(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTDouble>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTDouble { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Decimal.
  /// </summary>
  private static String? GetVTDecimal(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTDecimal>()?.Text;
  }
  
  private static bool CmpVTDecimal(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTDecimal>()?.Text == value;
  }
  
  private static void SetVTDecimal(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTDecimal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTDecimal { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LPSTR.
  /// </summary>
  private static String? GetVTLPSTR(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTLPSTR>()?.Text;
  }
  
  private static bool CmpVTLPSTR(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTLPSTR>()?.Text == value;
  }
  
  private static void SetVTLPSTR(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTLPSTR>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTLPSTR { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// LPWSTR.
  /// </summary>
  private static String? GetVTLPWSTR(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTLPWSTR>()?.Text;
  }
  
  private static bool CmpVTLPWSTR(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTLPWSTR>()?.Text == value;
  }
  
  private static void SetVTLPWSTR(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTLPWSTR>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTLPWSTR { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Basic String.
  /// </summary>
  private static String? GetVTBString(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTBString>()?.Text;
  }
  
  private static bool CmpVTBString(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTBString>()?.Text == value;
  }
  
  private static void SetVTBString(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTBString>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTBString { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Date and Time.
  /// </summary>
  private static String? GetVTDate(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTDate>()?.Text;
  }
  
  private static bool CmpVTDate(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTDate>()?.Text == value;
  }
  
  private static void SetVTDate(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTDate>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTDate { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// File Time.
  /// </summary>
  private static String? GetVTFileTime(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTFileTime>()?.Text;
  }
  
  private static bool CmpVTFileTime(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTFileTime>()?.Text == value;
  }
  
  private static void SetVTFileTime(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTFileTime>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTFileTime { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Boolean.
  /// </summary>
  private static String? GetVTBool(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTBool>()?.Text;
  }
  
  private static bool CmpVTBool(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTBool>()?.Text == value;
  }
  
  private static void SetVTBool(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTBool>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTBool { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Currency.
  /// </summary>
  private static String? GetVTCurrency(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTCurrency>()?.Text;
  }
  
  private static bool CmpVTCurrency(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTCurrency>()?.Text == value;
  }
  
  private static void SetVTCurrency(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTCurrency>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTCurrency { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Error Status Code.
  /// </summary>
  private static String? GetVTError(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTError>()?.Text;
  }
  
  private static bool CmpVTError(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTError>()?.Text == value;
  }
  
  private static void SetVTError(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTError>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTError { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Binary Stream.
  /// </summary>
  private static String? GetVTStreamData(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTStreamData>()?.Text;
  }
  
  private static bool CmpVTStreamData(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTStreamData>()?.Text == value;
  }
  
  private static void SetVTStreamData(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTStreamData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTStreamData { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Binary Stream Object.
  /// </summary>
  private static String? GetVTOStreamData(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTOStreamData>()?.Text;
  }
  
  private static bool CmpVTOStreamData(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTOStreamData>()?.Text == value;
  }
  
  private static void SetVTOStreamData(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTOStreamData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTOStreamData { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Binary Storage.
  /// </summary>
  private static String? GetVTStorage(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTStorage>()?.Text;
  }
  
  private static bool CmpVTStorage(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTStorage>()?.Text == value;
  }
  
  private static void SetVTStorage(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTStorage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTStorage { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Binary Storage Object.
  /// </summary>
  private static String? GetVTOStorage(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTOStorage>()?.Text;
  }
  
  private static bool CmpVTOStorage(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTOStorage>()?.Text == value;
  }
  
  private static void SetVTOStorage(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTOStorage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTOStorage { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Binary Versioned Stream.
  /// </summary>
  private static DMVT.VTVStreamData? GetVTVStreamData(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVT.VTVStreamData>();
    if (element != null)
      return DMXVT.VTVStreamDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVTVStreamData(DXCustProps.CustomDocumentProperty openXmlElement, DMVT.VTVStreamData? value, DiffList? diffs, string? objName)
  {
    return DMXVT.VTVStreamDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVT.VTVStreamData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVTVStreamData(DXCustProps.CustomDocumentProperty openXmlElement, DMVT.VTVStreamData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTVStreamData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVT.VTVStreamDataConverter.CreateOpenXmlElement<DXVT.VTVStreamData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Class ID.
  /// </summary>
  private static String? GetVTClassId(DXCustProps.CustomDocumentProperty openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTClassId>()?.Text;
  }
  
  private static bool CmpVTClassId(DXCustProps.CustomDocumentProperty openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXVT.VTClassId>()?.Text == value;
  }
  
  private static void SetVTClassId(DXCustProps.CustomDocumentProperty openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTClassId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXVT.VTClassId { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Clipboard Data.
  /// </summary>
  private static DMVT.VTClipboardData? GetVTClipboardData(DXCustProps.CustomDocumentProperty openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVT.VTClipboardData>();
    if (element != null)
      return DMXVT.VTClipboardDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVTClipboardData(DXCustProps.CustomDocumentProperty openXmlElement, DMVT.VTClipboardData? value, DiffList? diffs, string? objName)
  {
    return DMXVT.VTClipboardDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVT.VTClipboardData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVTClipboardData(DXCustProps.CustomDocumentProperty openXmlElement, DMVT.VTClipboardData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVT.VTClipboardData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVT.VTClipboardDataConverter.CreateOpenXmlElement<DXVT.VTClipboardData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Properties.CustomDocumentProperty? CreateModelElement(DXCustProps.CustomDocumentProperty? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.CustomDocumentProperty();
      value.FormatId = GetFormatId(openXmlElement);
      value.PropertyId = GetPropertyId(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.LinkTarget = GetLinkTarget(openXmlElement);
      value.VTVector = GetVTVector(openXmlElement);
      value.VTArray = GetVTArray(openXmlElement);
      value.VTBlob = GetVTBlob(openXmlElement);
      value.VTOBlob = GetVTOBlob(openXmlElement);
      value.VTEmpty = GetVTEmpty(openXmlElement);
      value.VTNull = GetVTNull(openXmlElement);
      value.VTByte = GetVTByte(openXmlElement);
      value.VTShort = GetVTShort(openXmlElement);
      value.VTInt32 = GetVTInt32(openXmlElement);
      value.VTInt64 = GetVTInt64(openXmlElement);
      value.VTInteger = GetVTInteger(openXmlElement);
      value.VTUnsignedByte = GetVTUnsignedByte(openXmlElement);
      value.VTUnsignedShort = GetVTUnsignedShort(openXmlElement);
      value.VTUnsignedInt32 = GetVTUnsignedInt32(openXmlElement);
      value.VTUnsignedInt64 = GetVTUnsignedInt64(openXmlElement);
      value.VTUnsignedInteger = GetVTUnsignedInteger(openXmlElement);
      value.VTFloat = GetVTFloat(openXmlElement);
      value.VTDouble = GetVTDouble(openXmlElement);
      value.VTDecimal = GetVTDecimal(openXmlElement);
      value.VTLPSTR = GetVTLPSTR(openXmlElement);
      value.VTLPWSTR = GetVTLPWSTR(openXmlElement);
      value.VTBString = GetVTBString(openXmlElement);
      value.VTDate = GetVTDate(openXmlElement);
      value.VTFileTime = GetVTFileTime(openXmlElement);
      value.VTBool = GetVTBool(openXmlElement);
      value.VTCurrency = GetVTCurrency(openXmlElement);
      value.VTError = GetVTError(openXmlElement);
      value.VTStreamData = GetVTStreamData(openXmlElement);
      value.VTOStreamData = GetVTOStreamData(openXmlElement);
      value.VTStorage = GetVTStorage(openXmlElement);
      value.VTOStorage = GetVTOStorage(openXmlElement);
      value.VTVStreamData = GetVTVStreamData(openXmlElement);
      value.VTClassId = GetVTClassId(openXmlElement);
      value.VTClipboardData = GetVTClipboardData(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCustProps.CustomDocumentProperty? openXmlElement, DMProps.CustomDocumentProperty? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormatId(openXmlElement, value.FormatId, diffs, objName))
        ok = false;
      if (!CmpPropertyId(openXmlElement, value.PropertyId, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpLinkTarget(openXmlElement, value.LinkTarget, diffs, objName))
        ok = false;
      if (!CmpVTVector(openXmlElement, value.VTVector, diffs, objName))
        ok = false;
      if (!CmpVTArray(openXmlElement, value.VTArray, diffs, objName))
        ok = false;
      if (!CmpVTBlob(openXmlElement, value.VTBlob, diffs, objName))
        ok = false;
      if (!CmpVTOBlob(openXmlElement, value.VTOBlob, diffs, objName))
        ok = false;
      if (!CmpVTEmpty(openXmlElement, value.VTEmpty, diffs, objName))
        ok = false;
      if (!CmpVTNull(openXmlElement, value.VTNull, diffs, objName))
        ok = false;
      if (!CmpVTByte(openXmlElement, value.VTByte, diffs, objName))
        ok = false;
      if (!CmpVTShort(openXmlElement, value.VTShort, diffs, objName))
        ok = false;
      if (!CmpVTInt32(openXmlElement, value.VTInt32, diffs, objName))
        ok = false;
      if (!CmpVTInt64(openXmlElement, value.VTInt64, diffs, objName))
        ok = false;
      if (!CmpVTInteger(openXmlElement, value.VTInteger, diffs, objName))
        ok = false;
      if (!CmpVTUnsignedByte(openXmlElement, value.VTUnsignedByte, diffs, objName))
        ok = false;
      if (!CmpVTUnsignedShort(openXmlElement, value.VTUnsignedShort, diffs, objName))
        ok = false;
      if (!CmpVTUnsignedInt32(openXmlElement, value.VTUnsignedInt32, diffs, objName))
        ok = false;
      if (!CmpVTUnsignedInt64(openXmlElement, value.VTUnsignedInt64, diffs, objName))
        ok = false;
      if (!CmpVTUnsignedInteger(openXmlElement, value.VTUnsignedInteger, diffs, objName))
        ok = false;
      if (!CmpVTFloat(openXmlElement, value.VTFloat, diffs, objName))
        ok = false;
      if (!CmpVTDouble(openXmlElement, value.VTDouble, diffs, objName))
        ok = false;
      if (!CmpVTDecimal(openXmlElement, value.VTDecimal, diffs, objName))
        ok = false;
      if (!CmpVTLPSTR(openXmlElement, value.VTLPSTR, diffs, objName))
        ok = false;
      if (!CmpVTLPWSTR(openXmlElement, value.VTLPWSTR, diffs, objName))
        ok = false;
      if (!CmpVTBString(openXmlElement, value.VTBString, diffs, objName))
        ok = false;
      if (!CmpVTDate(openXmlElement, value.VTDate, diffs, objName))
        ok = false;
      if (!CmpVTFileTime(openXmlElement, value.VTFileTime, diffs, objName))
        ok = false;
      if (!CmpVTBool(openXmlElement, value.VTBool, diffs, objName))
        ok = false;
      if (!CmpVTCurrency(openXmlElement, value.VTCurrency, diffs, objName))
        ok = false;
      if (!CmpVTError(openXmlElement, value.VTError, diffs, objName))
        ok = false;
      if (!CmpVTStreamData(openXmlElement, value.VTStreamData, diffs, objName))
        ok = false;
      if (!CmpVTOStreamData(openXmlElement, value.VTOStreamData, diffs, objName))
        ok = false;
      if (!CmpVTStorage(openXmlElement, value.VTStorage, diffs, objName))
        ok = false;
      if (!CmpVTOStorage(openXmlElement, value.VTOStorage, diffs, objName))
        ok = false;
      if (!CmpVTVStreamData(openXmlElement, value.VTVStreamData, diffs, objName))
        ok = false;
      if (!CmpVTClassId(openXmlElement, value.VTClassId, diffs, objName))
        ok = false;
      if (!CmpVTClipboardData(openXmlElement, value.VTClipboardData, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMProps.CustomDocumentProperty value)
    where OpenXmlElementType: DXCustProps.CustomDocumentProperty, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXCustProps.CustomDocumentProperty openXmlElement, DMProps.CustomDocumentProperty value)
  {
    SetFormatId(openXmlElement, value?.FormatId);
    SetPropertyId(openXmlElement, value?.PropertyId);
    SetName(openXmlElement, value?.Name);
    SetLinkTarget(openXmlElement, value?.LinkTarget);
    SetVTVector(openXmlElement, value?.VTVector);
    SetVTArray(openXmlElement, value?.VTArray);
    SetVTBlob(openXmlElement, value?.VTBlob);
    SetVTOBlob(openXmlElement, value?.VTOBlob);
    SetVTEmpty(openXmlElement, value?.VTEmpty);
    SetVTNull(openXmlElement, value?.VTNull);
    SetVTByte(openXmlElement, value?.VTByte);
    SetVTShort(openXmlElement, value?.VTShort);
    SetVTInt32(openXmlElement, value?.VTInt32);
    SetVTInt64(openXmlElement, value?.VTInt64);
    SetVTInteger(openXmlElement, value?.VTInteger);
    SetVTUnsignedByte(openXmlElement, value?.VTUnsignedByte);
    SetVTUnsignedShort(openXmlElement, value?.VTUnsignedShort);
    SetVTUnsignedInt32(openXmlElement, value?.VTUnsignedInt32);
    SetVTUnsignedInt64(openXmlElement, value?.VTUnsignedInt64);
    SetVTUnsignedInteger(openXmlElement, value?.VTUnsignedInteger);
    SetVTFloat(openXmlElement, value?.VTFloat);
    SetVTDouble(openXmlElement, value?.VTDouble);
    SetVTDecimal(openXmlElement, value?.VTDecimal);
    SetVTLPSTR(openXmlElement, value?.VTLPSTR);
    SetVTLPWSTR(openXmlElement, value?.VTLPWSTR);
    SetVTBString(openXmlElement, value?.VTBString);
    SetVTDate(openXmlElement, value?.VTDate);
    SetVTFileTime(openXmlElement, value?.VTFileTime);
    SetVTBool(openXmlElement, value?.VTBool);
    SetVTCurrency(openXmlElement, value?.VTCurrency);
    SetVTError(openXmlElement, value?.VTError);
    SetVTStreamData(openXmlElement, value?.VTStreamData);
    SetVTOStreamData(openXmlElement, value?.VTOStreamData);
    SetVTStorage(openXmlElement, value?.VTStorage);
    SetVTOStorage(openXmlElement, value?.VTOStorage);
    SetVTVStreamData(openXmlElement, value?.VTVStreamData);
    SetVTClassId(openXmlElement, value?.VTClassId);
    SetVTClipboardData(openXmlElement, value?.VTClipboardData);
  }
}
