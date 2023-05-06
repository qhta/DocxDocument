namespace DocumentModel.OpenXml;

public static class SimpleValueConverter
{
  #region SimpleValue
  public static T? GetValue<T>(OpenXmlComparableSimpleValue<T>? element)
    where T : struct, IComparable, IComparable<T>, IEquatable<T>
  {
    if (element?.Value == null)
      return null;
    return element.Value;
  }

  public static bool CmpValue<T>(OpenXmlComparableSimpleValue<T>? element, T? value, DiffList? diffs = null, string? objName = null, string? propName = null)
    where T : struct, IComparable, IComparable<T>, IEquatable<T>
  {
    if (element?.Value == null && value == null) return true;
    if (element is not null && element.Value.Equals(value)) return true;
    diffs?.Add(objName, propName, element?.Value, value);
    return false;
  }

  public static void SetValue<ElementType, T>(OpenXmlCompositeElement openXmlElement, T? value)
    where ElementType: OpenXmlElement, new()
     where T : struct, IComparable, IComparable<T>, IEquatable<T>
  {
    var valProperty = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    Debug.Assert(valProperty!=null);
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
      if (typeof(T) == typeof(Int16))
        valProperty.SetValue(itemElement, new Int16Value(Convert.ToInt16(value)));
      else
      if (typeof(T) == typeof(UInt32))
        valProperty.SetValue(itemElement, new UInt32Value(Convert.ToUInt32(value)));
      else
        valProperty.SetValue(itemElement, value);
      openXmlElement.AppendChild(itemElement);
    }
  }
  //public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Int32? value)
  //  where OpenXmlElementType : OpenXmlElement, new()
  //{
  //  var element = new OpenXmlElementType();
  //  var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
  //  if (valProperty != null)
  //    valProperty.SetValue(element, value);
  //  else if (element is OpenXmlLeafTextElement textElement)
  //    if (value!=null)
  //      textElement.Text = ((Int32)value).ToString();
  //  return element;
  //}
  #endregion

  //#region OpenXmlLeafTextElement
  //public static Int32? GetValue(OpenXmlLeafTextElement? element)
  //{
  //  if (element?.Text != null)
  //  {
  //    if (Int32.TryParse(element.Text, out var value)) 
  //     return value;
  //  }
  //  return null;
  //}

  //public static bool CmpValue(OpenXmlLeafTextElement element, Int32? value, DiffList? diffs = null, string? objName = null)
  //{
  //  if (GetValue(element) == value)
  //    diffs?.Add(objName, element.GetType().ToString(), element.Text, value);
  //  return false;
  //}

  //public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Int32? value)
  //  where OpenXmlElementType : OpenXmlElement, new()
  //{
  //  var element = new OpenXmlElementType();
  //  var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
  //  if (valProperty != null)
  //    valProperty.SetValue(element, value);
  //  else if (element is OpenXmlLeafTextElement textElement)
  //    if (value!=null)
  //      textElement.Text = ((Int32)value).ToString();
  //  return element;
  //}
  //#endregion
}