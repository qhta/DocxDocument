namespace DocumentModel.OpenXml;

public static class UInt32ValueConverter
{
  public static UInt32? GetValue(DXDC.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXDC.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static UInt32? GetValue(DXO16DC.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXO16DC.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static UInt32? GetValue(DXO16DCD.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static bool CmpValue(DXO16DCD.UnsignedIntegerType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static UInt32? GetValue(DXW.LongHexNumberType element)
  {
    if (element.Val?.Value != null)
      return UInt32.Parse(element.Val.Value, NumberStyles.HexNumber);
    return null;
  }

  public static bool CmpValue(DXW.LongHexNumberType element, UInt32? value, DiffList? diffs, string? objName)
  {
    if (element.Val?.Value == null && value == null) return true;
    if (element.Val?.Value !=null && UInt32.Parse(element.Val.Value, NumberStyles.HexNumber) == value) return true;
    diffs?.Add(objName, element.GetType().ToString(), element.Val?.Value, value);
    return false;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(UInt32 value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }


  #region StringValue conversion.
  /// <summary>
  /// Converts StringValue to UInt32.
  /// </summary>
  /// <param name="stringValue">StringValue to Convert</param>
  /// <returns>UInt32 value of element content (or <c>null</c> if element has no content or conversion is impossible).</returns>
  public static UInt32? GetValue(StringValue? stringValue)
  {
    if (stringValue?.Value != null)
    {
      if (UInt32.TryParse(stringValue.Value, out var value))
        return value;
    }
    return null;
  }

  /// <summary>
  /// Compares a value get from OpenXml StringValue to UInt32 value.
  /// </summary>
  /// <param name="element">StringValue to compare.</param>
  /// <param name="value">UInt32 value to compare (can be null)</param>
  /// <param name="diffs">Differences list (defined in <see cref="Qhta.DeepCompare"/> assembly).</param>
  /// <param name="objName">Name of the compared object (to pass to <see cref="diffs"/> collection).</param>
  /// <returns><c>True</c> if the values are equal or both are null, <c>false</c> otherwise</returns>
  public static bool CmpValue(StringValue? element, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (GetValue(element) == value) return true;
    diffs?.Add(objName, propName ?? element?.GetType().ToString(), element?.Value, value);
    return false;
  }

  public static StringValue? CreateStringValue(UInt32? value)
  {
    if (value == null) return null;
    return new StringValue { Value = value.ToString() };
  }

  public static void SetValue<ElementType>(OpenXmlCompositeElement openXmlElement, UInt32? value)
    where ElementType : TypedOpenXmlLeafElement, new()
  {
    var valProperty = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    Debug.Assert(valProperty != null);
    var itemElement = openXmlElement.GetFirstChild<ElementType>();
    if (itemElement != null)
    {
      if (value != null)
        valProperty.SetValue(itemElement, value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
    {
      itemElement = new ElementType();
      valProperty.SetValue(itemElement, new StringValue(value.ToString()));
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion
}