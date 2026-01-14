namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for simple value types in Open XML elements.
/// </summary>
public static class SimpleValueConverter
{
  #region SimpleValue
  /// <summary>
  /// Retrieves the value of an OpenXmlComparableSimpleValue element.
  /// </summary>
  /// <typeparam name="T">The underlying value type.</typeparam>
  /// <param name="element">The OpenXmlComparableSimpleValue element.</param>
  /// <returns>The value of the element, or null if the element or its value is null.</returns>
  public static T? GetValue<T>(OpenXmlComparableSimpleValue<T>? element)
    where T : struct, IComparable, IComparable<T>, IEquatable<T>
  {
    if (element?.Value == null)
      return null;
    return element.Value;
  }

  /// <summary>
  /// Sets the value of a specific element type within an OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="ElementType">The type of the OpenXmlElement to set.</typeparam>
  /// <typeparam name="T">The type of the value to set.</typeparam>
  /// <param name="openXmlElement">The parent OpenXmlCompositeElement.</param>
  /// <param name="value">The value to set. If null, the element is removed if it exists.</param>
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

  /// <summary>
  /// Removes a specific element type from an OpenXmlCompositeElement, effectively setting its value to null.
  /// </summary>
  /// <typeparam name="ElementType">The type of the OpenXmlElement to remove.</typeparam>
  /// <param name="openXmlElement">The parent OpenXmlCompositeElement.</param>
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