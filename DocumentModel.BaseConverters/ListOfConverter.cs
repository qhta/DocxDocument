namespace DocumentModel.OpenXml;
// ReSharper disable InvokeAsExtensionMember

/// <summary>
/// Provides conversion methods for ListValue types in Open XML.
/// </summary>
public static class ListOfConverter
{
  #region List<String> access methods

  /// <summary>
  /// Retrieves a list of strings from a ListValue of StringValue elements.
  /// </summary>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A List strings, or null if the input is null.</returns>
  public static List<String>? GetValue(DX.ListValue<DX.StringValue>? element)
  {
    if (element == null) return null;

    var result = new List<String>();
    foreach (var item in element)
    {
      var str = StringConverter.ConvertFrom(item);
      if (str != null)
        result.Add(str);
    }
    return result;
  }

  /// <summary>
  /// Creates a ListValue of StringValue elements from a List strings.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="value">The list of strings to convert.</param>
  /// <returns>A new ListValue containing the strings.</returns>
  public static DX.ListValue<DX.StringValue>? CreateListValue<OpenXmlElementType>(List<String> value)
  {
    var resultList = new List<DX.StringValue>();
    foreach (var item in value)
    {
      var itemObject = new DX.StringValue(item);
      resultList.Add(itemObject);
    }
    var element = new DX.ListValue<DX.StringValue>(resultList);
    return element;
  }

  #endregion

  #region List<EnumKind> access methods

  /// <summary>
  /// Retrieves a list of enum values from a ListValue of EnumValue elements.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="EnumKind">The model enum type.</typeparam>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A List enums, or null if the input is null.</returns>
  public static ListOf<EnumKind>? GetValue<OpenXmlEnumType, EnumKind>(DX.ListValue<DX.EnumValue<OpenXmlEnumType>>? element)
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where EnumKind : struct, IConvertible
  {
    if (element != null)
    {
      var result = new ListOf<EnumKind>();
      foreach (var item in element)
      {
        var itemValue = EnumTypeConverter.GetEnumValue<OpenXmlEnumType, EnumKind>(item);
        if (itemValue != null)
          result.Add((EnumKind)itemValue);
      }
      return result;
    }
    return null;
  }

  /// <summary>
  /// Creates a ListValue of EnumValue elements from a List enums.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="EnumKind">The model enum type.</typeparam>
  /// <param name="value">The list of enum values to convert.</param>
  /// <returns>A new ListValue containing the enum values.</returns>
  public static DX.ListValue<DX.EnumValue<OpenXmlEnumType>>? CreateListValue<OpenXmlEnumType, EnumKind>(List<EnumKind> value)
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where EnumKind : struct, Enum
  {
    var resultList = new List<DX.EnumValue<OpenXmlEnumType>>();
    foreach (var item in value)
    {
      var itemObject = EnumTypeConverter.CreateOpenXmlEnumValue<OpenXmlEnumType, EnumKind>(item);
      if (itemObject != null)
        resultList.Add(itemObject);
    }
    var element = new DX.ListValue<DX.EnumValue<OpenXmlEnumType>>(resultList);
    return element;
  }

  #endregion

  #region List<Boolean> access methods

  /// <summary>
  /// Retrieves a list of boolean values from a ListValue of BooleanValue elements.
  /// </summary>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A List booleans, or null if the input is null.</returns>
  public static List<Boolean>? GetValue(DX.ListValue<DX.BooleanValue>? element)
  {
    if (element != null)
    {
      var result = new List<Boolean>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  /// <summary>
  /// Creates a ListValue of BooleanValue elements from a List booleans.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="value">The list of boolean values to convert.</param>
  /// <returns>A new ListValue containing the boolean values.</returns>
  public static DX.ListValue<DX.BooleanValue>? CreateListValue<OpenXmlElementType>(List<Boolean> value)
  {
    var resultList = new List<DX.BooleanValue>();
    foreach (var item in value)
    {
      var itemObject = new DX.BooleanValue(item);
      resultList.Add(itemObject);
    }
    var element = new DX.ListValue<DX.BooleanValue>(resultList);
    return element;
  }

  #endregion

  #region List<Int32> access methods

  /// <summary>
  /// Retrieves a list of Int32 values from a ListValue of Int32Value elements.
  /// </summary>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A List Int32s, or null if the input is null.</returns>
  public static List<Int32>? GetValue(DX.ListValue<DX.Int32Value>? element)
  {
    if (element != null)
    {
      var result = new List<Int32>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  /// <summary>
  /// Creates a ListValue of Int32Value elements from a List Int32s.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="value">The list of Int32 values to convert.</param>
  /// <returns>A new ListValue containing the Int32 values.</returns>
  public static DX.ListValue<DX.Int32Value>? CreateListValue<OpenXmlElementType>(List<Int32> value)
  {
    var resultList = new List<DX.Int32Value>();
    foreach (var item in value)
    {
      var itemObject = new DX.Int32Value(item);
      resultList.Add(itemObject);
    }
    var element = new DX.ListValue<DX.Int32Value>(resultList);
    return element;
  }

  #endregion

  #region List<UInt32> access methods

  /// <summary>
  /// Retrieves a list of UInt32 values from a ListValue of UInt32Value elements.
  /// </summary>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A List UInt32s, or null if the input is null.</returns>
  public static List<UInt32>? GetValue(DX.ListValue<DX.UInt32Value>? element)
  {
    if (element != null)
    {
      var result = new List<UInt32>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  /// <summary>
  /// Creates a ListValue of UInt32Value elements from a List UInt32s.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="value">The list of UInt32 values to convert.</param>
  /// <returns>A new ListValue containing the UInt32 values.</returns>
  public static DX.ListValue<DX.UInt32Value>? CreateListValue<OpenXmlElementType>(List<UInt32> value)
  {
    var resultList = new List<DX.UInt32Value>();
    foreach (var item in value)
    {
      var itemObject = new DX.UInt32Value(item);
      resultList.Add(itemObject);
    }
    var element = new DX.ListValue<DX.UInt32Value>(resultList);
    return element;
  }

  #endregion
}
