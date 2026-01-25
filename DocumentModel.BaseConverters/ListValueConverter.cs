


namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for ListValue types in Open XML.
/// </summary>
public static class ListValueConverter
{
  #region ListOf<String> access methods
  /// <summary>
  /// Retrieves a list of strings from a ListValue of StringValue elements.
  /// </summary>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A ListOf strings, or null if the input is null.</returns>
  public static ListOf<String>? GetValue(DX.ListValue<DX.StringValue>? element)
  {
    if (element == null) return null;

    var result = new ListOf<String>();
    foreach (var item in element)
    {
      var str = StringOpenXmlConverter.GetValue(item);
      if (str!=null)
        result.Add(str);
    }
    return result;
  }

  /// <summary>
  /// Creates a ListValue of StringValue elements from a ListOf strings.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="value">The list of strings to convert.</param>
  /// <returns>A new ListValue containing the strings.</returns>
  public static DX.ListValue<DX.StringValue>? CreateListValue<OpenXmlElementType>(ListOf<String> value)
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

  #region ListOf<EnumKind> access methods
  /// <summary>
  /// Retrieves a list of enum values from a ListValue of EnumValue elements.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="EnumKind">The model enum type.</typeparam>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A ListOf enums, or null if the input is null.</returns>
  public static ListOf<EnumKind>? GetValue<OpenXmlEnumType, EnumKind>(DX.ListValue<DX.EnumValue<OpenXmlEnumType>>? element)
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where EnumKind : struct, IConvertible
  {
    if (element != null)
    {
      var result = new ListOf<EnumKind>();
      foreach (var item in element)
      {
        var itemValue = EnumOpenXmlConverter.GetEnumValue<OpenXmlEnumType, EnumKind>(item);
        if (itemValue != null)
          result.Add((EnumKind)itemValue);
      }
    }
    return null;
  }

  /// <summary>
  /// Creates a ListValue of EnumValue elements from a ListOf enums.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">The OpenXml enum type.</typeparam>
  /// <typeparam name="EnumKind">The model enum type.</typeparam>
  /// <param name="value">The list of enum values to convert.</param>
  /// <returns>A new ListValue containing the enum values.</returns>
  public static DX.ListValue<DX.EnumValue<OpenXmlEnumType>>? CreateListValue<OpenXmlEnumType, EnumKind>(ListOf<EnumKind> value)
    where OpenXmlEnumType : struct, DX.IEnumValue, DX.IEnumValueFactory<OpenXmlEnumType>
    where EnumKind : struct, IConvertible
  {
    var resultList = new List<DX.EnumValue<OpenXmlEnumType>>();
    foreach (var item in value)
    {
      var itemObject = EnumOpenXmlConverter.CreateEnumValue<OpenXmlEnumType, EnumKind>(item);
      if (itemObject != null)
        resultList.Add(itemObject);
    }
    var element = new DX.ListValue<DX.EnumValue<OpenXmlEnumType>>(resultList);
    return element;
  }
  #endregion

  #region ListOf<Boolean> access methods
  /// <summary>
  /// Retrieves a list of boolean values from a ListValue of BooleanValue elements.
  /// </summary>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A ListOf booleans, or null if the input is null.</returns>
  public static ListOf<Boolean>? GetValue(DX.ListValue<DX.BooleanValue>? element)
  {
    if (element != null)
    {
      var result = new ListOf<Boolean>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  /// <summary>
  /// Creates a ListValue of BooleanValue elements from a ListOf booleans.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="value">The list of boolean values to convert.</param>
  /// <returns>A new ListValue containing the boolean values.</returns>
  public static DX.ListValue<DX.BooleanValue>? CreateListValue<OpenXmlElementType>(ListOf<Boolean> value)
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

  #region ListOf<Int32> access methods
  /// <summary>
  /// Retrieves a list of Int32 values from a ListValue of Int32Value elements.
  /// </summary>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A ListOf Int32s, or null if the input is null.</returns>
  public static ListOf<Int32>? GetValue(DX.ListValue<DX.Int32Value>? element)
  {
    if (element != null)
    {
      var result = new ListOf<Int32>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  /// <summary>
  /// Creates a ListValue of Int32Value elements from a ListOf Int32s.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="value">The list of Int32 values to convert.</param>
  /// <returns>A new ListValue containing the Int32 values.</returns>
  public static DX.ListValue<DX.Int32Value>? CreateListValue<OpenXmlElementType>(ListOf<Int32> value)
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

  #region ListOf<UInt32> access methods
  /// <summary>
  /// Retrieves a list of UInt32 values from a ListValue of UInt32Value elements.
  /// </summary>
  /// <param name="element">The ListValue element to convert.</param>
  /// <returns>A ListOf UInt32s, or null if the input is null.</returns>
  public static ListOf<UInt32>? GetValue(DX.ListValue<DX.UInt32Value>? element)
  {
    if (element != null)
    {
      var result = new ListOf<UInt32>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  /// <summary>
  /// Creates a ListValue of UInt32Value elements from a ListOf UInt32s.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="value">The list of UInt32 values to convert.</param>
  /// <returns>A new ListValue containing the UInt32 values.</returns>
  public static DX.ListValue<DX.UInt32Value>? CreateListValue<OpenXmlElementType>(ListOf<UInt32> value)
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