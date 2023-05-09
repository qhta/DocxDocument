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
      if (typeof(T) == typeof(Int32))
        valProperty.SetValue(itemElement, new Int32Value(Convert.ToInt32(value)));
      else
      if (typeof(T) == typeof(UInt32))
        valProperty.SetValue(itemElement, new UInt32Value(Convert.ToUInt32(value)));
      else
        valProperty.SetValue(itemElement, value);
      openXmlElement.AppendChild(itemElement);
    }
  }

  public static void SetNullValue<ElementType>(OpenXmlCompositeElement openXmlElement)
    where ElementType: OpenXmlElement, new()
  {
    var valProperty = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    Debug.Assert(valProperty!=null);
    var itemElement = openXmlElement.GetFirstChild<ElementType>();
    if (itemElement != null)
        itemElement.Remove();
  }
  #endregion
}