namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for boolean values to/from Open XML.
/// </summary>
public static class BooleanOpenXmlConverter
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DXW.EmptyType),
    typeof(DX.OnOffValue),
    typeof(DXW.OnOffOnlyValues),
    typeof(DX.EnumValue<DXW.OnOffOnlyValues>),
    typeof(DXW.OnOffType),
    typeof(DXM.OnOffType),
    typeof(DXW.OnOffOnlyType),
    typeof(DXO10W.OnOffValues),
    typeof(DX.EnumValue<DXO10W.OnOffValues>),
    typeof(DXO10W.OnOffType),
    typeof(DXO13W.OnOffType),
    typeof(DX.BooleanValue),
    typeof(DXM.BooleanValues),
    typeof(DX.TrueFalseValue),
    typeof(DX.TrueFalseBlankValue),
    typeof(DX.EnumValue<DXM.BooleanValues>),
    typeof(DXM.OnOffType),
    typeof(DX.OpenXmlLeafTextElement),
  ];

  #region DXW.EmptyType conversion.

  /// <summary>
  /// Converts a nullable Boolean value to an Open XML DXW.EmptyType element.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The target type for the element.</param>
  /// <returns>An instance of DXW.EmptyType, or null if value is null or false.</returns>
  public static DXW.EmptyType? ConvertBoolToDXWEmptyType(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (value == true)
      return (DXW.EmptyType)Activator.CreateInstance(targetType)!;

    return null;
  }

  /// <summary>
  /// Converts a nullable Open XML DXW.EmptyType value to a nullable Boolean value indicating presence.
  /// </summary>
  /// <param name="openXmlElement">The DXW.EmptyType value to convert. If the element is present, then returns.</param>
  /// <returns>True if value is not null; otherwise false<see
  /// langword="null"/>.</returns>
  public static bool ConvertToBool(DXW.EmptyType? openXmlElement)
  {
    return openXmlElement != null;
  }

  #endregion

  #region DXO10W.EmptyType conversion.

  /// <summary>
  /// Converts a nullable Boolean value to an Open XML DXO10W.EmptyType element.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The target type for the element.</param>
  /// <returns>An instance of DXO10W.EmptyType, or null if value is null or false.</returns>
  public static DXO10W.EmptyType? ConvertBoolToDXO10WEmptyType(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (value == true)
      return (DXO10W.EmptyType)Activator.CreateInstance(targetType)!;

    return null;
  }

  /// <summary>
  /// Converts a nullable Open XML DXO10W.EmptyType value to a nullable Boolean value indicating presence.
  /// </summary>
  /// <param name="openXmlElement">The DXO10W.EmptyType value to convert. If the element is present, then returns.</param>
  /// <returns>True if value is not null; otherwise false<see
  /// langword="null"/>.</returns>
  public static bool ConvertToBool(DXO10W.EmptyType? openXmlElement)
  {
    return openXmlElement != null;
  }

  #endregion

  #region DXD.EmptyType conversion.

  /// <summary>
  /// Converts a nullable Boolean value to an Open XML DXD.EmptyType element.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The target type for the element.</param>
  /// <returns>An instance of DXD.EmptyType, or null if value is null or false.</returns>
  public static DXD.EmptyType? ConvertBoolToDXDEmptyType(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (value == true)
      return (DXD.EmptyType)Activator.CreateInstance(targetType)!;

    return null;
  }

  /// <summary>
  /// Converts a nullable Open XML DXD.EmptyType value to a nullable Boolean value indicating presence.
  /// </summary>
  /// <param name="openXmlElement">The DXD.EmptyType value to convert. If the element is present, then returns.</param>
  /// <returns>True if value is not null; otherwise false<see
  /// langword="null"/>.</returns>
  public static bool ConvertToBool(DXD.EmptyType? openXmlElement)
  {
    return openXmlElement != null;
  }

  #endregion

  #region OnOffValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffValue element.
  /// </summary>
  /// <param name="element">The OnOffValue element to check.</param>
  /// <returns>A boolean representing the value, or null if the element is null.</returns>
  public static Boolean? ConvertToBool(DX.OnOffValue? element)
  {
    return element?.Value;
  }

  /// <summary>
  /// Creates an OnOffValue using specified string representations for false and true.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="falseString">The string representation for false (default is "0").</param>
  /// <param name="trueString">The string representation for true (default is "1").</param>
  /// <returns>A new OnOffValue object, or null if the input value is null.</returns>
  public static DX.OnOffValue? ConvertBoolToOnOffValue(Boolean? value, string? falseString = null, string? trueString = null)
  {
    if (value == null) return null;

    if (trueString == null)
    {
      falseString = "0";
      trueString = "1";
    }
    var val = (Boolean)value ? trueString : falseString;
    if (val == null)
      return null;

    return new DX.OnOffValue { InnerText = val };
  }

  #endregion

  #region OnOffOnlyValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffOnlyValues element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static Boolean? ConvertToBool(DXW.OnOffOnlyValues? openXmlElement)
  {
    if (openXmlElement == null) return null;

    return openXmlElement == DXW.OnOffOnlyValues.On;
  }

  /// <summary>
  /// Creates an OnOffOnlyValues element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  public static DXW.OnOffOnlyValues? ConvertBoolToEnumOnOffOnlyValue(Boolean? value)
  {
    if (value == true) return DXW.OnOffOnlyValues.On;
    if (value == false) return DXW.OnOffOnlyValues.Off;

    return null;
  }

  #endregion

  #region EnumValue<OnOffOnlyValues> conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified EnumValue&lt;OnOffOnlyValues&gt; element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static Boolean? ConvertEnumValueToBool(DX.EnumValue<DXW.OnOffOnlyValues>? openXmlElement)
  {
    if (openXmlElement == null) return null;

    return openXmlElement == DXW.OnOffOnlyValues.On;
  }

  /// <summary>
  /// Creates an EnumValue&lt;OnOffOnlyValues&gt; element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  public static DX.EnumValue<DXW.OnOffOnlyValues>? ConvertBoolToOnOffOnlyValue(Boolean? value)
  {
    if (value == true) return new DX.EnumValue<DXW.OnOffOnlyValues>(DXW.OnOffOnlyValues.On);
    if (value == false) return new DX.EnumValue<DXW.OnOffOnlyValues>(DXW.OnOffOnlyValues.Off);

    return null;
  }

  #endregion

  #region TrueFalseValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified TrueFalseValue element.
  /// </summary>
  /// <param name="value">The TrueFalseValue element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static Boolean? ConvertToBool(DX.TrueFalseValue? value)
  {
    if (value == null) return null;

    return DX.TrueFalseValue.ToBoolean(value);
  }

  /// <summary>
  /// Creates an TrueFalseValue element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>TrueFalseValue.On if true, TrueFalseValue.Off if false, otherwise null.</returns>
  public static DX.TrueFalseValue? ConvertBoolToTrueFalseValue(Boolean? value)
  {
    if (value == null) return null;

    var result = new DX.TrueFalseValue((bool)value!);
    return result;
  }

  #endregion

  #region TrueFalseOnlyValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified TrueFalseBlankValue element.
  /// </summary>
  /// <param name="value">The TrueFalseBlankValue element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static Boolean? ConvertToBool(DX.TrueFalseBlankValue? value)
  {
    if (value == null) return null;

    return DX.TrueFalseBlankValue.ToBoolean(value);
  }

  /// <summary>
  /// Creates an TrueFalseBlankValue element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>TrueFalseBlankValue.On if true, TrueFalseBlankValue.Off if false, otherwise null.</returns>
  public static DX.TrueFalseBlankValue? ConvertBoolToTrueFalseBlankValue(Boolean? value)
  {
    if (value == null) return null;

    return DX.TrueFalseBlankValue.FromBoolean((bool)value!);
  }

  #endregion

  #region DXW.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXW.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null, or null if element is null.</returns>
  public static Boolean? ConvertToBool(DXW.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return true;

    return openXmlElement.Val?.Value;
  }

  /// <summary>
  /// Creates a new instance of the specified DXW.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXW.OnOffType? CreateOnOffType(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXW.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXW.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region DXO10W.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXW.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null, or null if element is null.</returns>
  public static Boolean? ConvertO10WToBool(DXO10W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return true;

    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      throw new InvalidOperationException("Missing OnOffType value.");

    if (enumVal == DXO10W.OnOffValues.True
        || enumVal== DXO10W.OnOffValues.One) 
      return true;
    if (enumVal == DXO10W.OnOffValues.False
        || enumVal == DXO10W.OnOffValues.Zero)
      return true;

    throw new InvalidOperationException("Unknown OnOffType value.");
  }

  /// <summary>
  /// Creates a new instance of the specified DXO10W.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXO10W.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXO10W.OnOffType? CreateOnOffO10WType(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXO10W.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXO10W.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = (bool)value ? DXO10W.OnOffValues.True : DXO10W.OnOffValues.False;
    return element;
  }

  #endregion

  #region DXO13W.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXO13W.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null, or null if element is null.</returns>
  public static Boolean? ConvertO13WToBool(DXO13W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return true;

    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      throw new InvalidOperationException("Missing OnOffType value.");

    return enumVal;

    throw new InvalidOperationException("Unknown OnOffType value.");
  }

  /// <summary>
  /// Creates a new instance of the specified DXO13W.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXO13W.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXO13W.OnOffType? CreateOnOffO13WType(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXO13W.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXO13W.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region DXM.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXM.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null, or null if element is null.</returns>
  public static Boolean? ConvertMathToBool(DXM.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return true;

    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      throw new InvalidOperationException("Missing OnOffType value.");

    if (enumVal == DXM.BooleanValues.True
        || enumVal == DXM.BooleanValues.One
        || enumVal == DXM.BooleanValues.On)
      return true;
    if (enumVal == DXM.BooleanValues.False
        || enumVal == DXM.BooleanValues.Zero
        || enumVal == DXM.BooleanValues.Off)
      return true;

    throw new InvalidOperationException("Unknown OnOffType value.");
  }

  /// <summary>
  /// Creates a new instance of the specified DXM.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXM.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXM.OnOffType? CreateOnOffMathType(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXM.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXM.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = (bool)value ? DXM.BooleanValues.One : DXM.BooleanValues.Zero;
    return element;
  }

  #endregion

  #region OnOffOnlyType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffOnlyType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyType element to check.</param>
  /// <returns>True if the value is On, false if the value is Off, or true if the element exists without a value.</returns>
  public static Boolean? ConvertToBool(DXW.OnOffOnlyType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value == DXW.OnOffOnlyValues.On;

    return openXmlElement != null;
  }

  /// <summary>
  /// Creates a new instance of the specified OnOffOnlyType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffOnlyType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffOnlyType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXW.OnOffOnlyType? CreateOnOffOnlyType(Boolean? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.OnOffOnlyType)Activator.CreateInstance(targetType)!;
    element.Val = new DX.EnumValue<DXW.OnOffOnlyValues>(value == true ? DXW.OnOffOnlyValues.On : DXW.OnOffOnlyValues.Off);
    return element;
  }

  #endregion

  #region Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="value">The OnOffValues to get boolean value.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean? ConvertToBool(DXO10W.OnOffValues? value)
  {
    if (value == null) return null;
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return true;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return false;

    return null;
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding Open XML OnOffValues enumeration value.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If <see langword="true"/>, returns <c>OnOffValues.One</c>; if <see
  /// langword="false"/>, returns <c>OnOffValues.Zero</c>; if <see langword="null"/>, returns <see langword="null"/>.</param>
  /// <returns>A <c>DXO10W.OnOffValues</c> value representing the Boolean input, or <see langword="null"/> if <paramref
  /// name="value"/> is <see langword="null"/>.</returns>
  public static DXO10W.OnOffValues? ConvertToOnOff10Value(Boolean? value)
  {
    if (value == null) return null;

    return value == true ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero;
  }

  #endregion

  #region EnumValue of Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean? ConvertToBool(DX.EnumValue<DXO10W.OnOffValues>? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      var value = openXmlElement.Value;
      if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
        return true;
      if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
        return false;
    }
    return null;
  }

  /// <summary>
  /// Converts a boolean value to enum value of Office2010 Word OnOffValue.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>An <see cref="OnOffValues"/> corresponding to the specified Boolean value, or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DX.EnumValue<DXO10W.OnOffValues>? CreateOnOff10EnumValue(Boolean? value)
  {
    if (value == null) return null;

    return new DX.EnumValue<DXO10W.OnOffValues>(value == true ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero);
  }

  #endregion

  #region Office2010 Word OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean? ConvertToBool(DXO10W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var value = openXmlElement.Val?.Value;
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return true;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return false;

    return null;
  }

  /// <summary>
  /// Creates a new instance of the specified OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXO10W.OnOffType? CreateOnOff10Type(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.GetConstructor([typeof(bool)]) != null)
      return (DXO10W.OnOffType)Activator.CreateInstance(targetType, value == true)!;

    var element = (DXO10W.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = new DX.EnumValue<DXO10W.OnOffValues>(value == true ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero);
    return element;
  }

  #endregion

  #region Office2010 Word OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2013 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean? ConvertToBool(DXO13W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var value = openXmlElement.Val?.Value;
    return value;
  }

  /// <summary>
  /// Creates a new instance of the specified Word 2013 OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the Word 2013 OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of Word 2013 OnOffType to instantiate. Must be a type derived from DXO13W.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXO13W.OnOffType? CreateOnOff13Type(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.GetConstructor([typeof(bool)]) != null)
      return (DXO13W.OnOffType)Activator.CreateInstance(targetType, value == true)!;

    var element = (DXO13W.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region BooleanValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified BooleanValue comparable simple value.
  /// </summary>
  /// <param name="value">The value to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  public static Boolean? ConvertToBool(DX.BooleanValue? value)
  {
    if (value == null)
      return null;

    return value;
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding OpenXml BooleanValue representation.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If null, the method returns null.</param>
  /// <returns>A DX.BooleanValue value representing the Boolean input</returns>
  public static DX.BooleanValue? ConvertToBooleanValue(Boolean? value)
  {
    if (value == null) return null;

    return new DX.BooleanValue(value);
  }

  #endregion

  #region Math BooleanValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Math BooleanValues enum value.
  /// </summary>
  /// <param name="value">The value to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  public static Boolean? ConvertToBool(DXM.BooleanValues? value)
  {
    if (value == null)
      return null;
    if (value == DXM.BooleanValues.True || value == DXM.BooleanValues.On || value == DXM.BooleanValues.One)
      return true;
    if (value == DXM.BooleanValues.False || value == DXM.BooleanValues.Off || value == DXM.BooleanValues.Zero)
      return false;

    return null;
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding OpenXml Math BooleanValues representation.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If null, the method returns null.</param>
  /// <returns>A DXM.BooleanValues value representing the Boolean input: DXM.BooleanValues.One if <paramref name="value"/> is
  /// <see langword="true"/>, DXM.BooleanValues.Zero if <paramref name="value"/> is <see langword="false"/>, or null if
  /// <paramref name="value"/> is null.</returns>
  public static DXM.BooleanValues? ConvertToMathBooleanValue(Boolean? value)
  {
    if (value == null) return null;

    return value == true ? DXM.BooleanValues.One : DXM.BooleanValues.Zero;
  }

  #endregion

  #region EnumValue of Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean? ConvertBoolValuesEnumToBool(DX.EnumValue<DXM.BooleanValues>? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      var value = openXmlElement.Value;
      if (value == DXM.BooleanValues.True || value == DXM.BooleanValues.On || value == DXM.BooleanValues.One)
        return true;
      if (value == DXM.BooleanValues.False || value == DXM.BooleanValues.Off || value == DXM.BooleanValues.Zero)
        return false;
    }
    return null;
  }

  /// <summary>
  /// Converts a boolean value to enum value of Office2010 Word OnOffValue.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>An <see cref="OnOffValues"/> corresponding to the specified Boolean value, or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DX.EnumValue<DXM.BooleanValues>? CreateMathOnOffEnumValue(Boolean? value)
  {
    if (value == null) return null;

    return new DX.EnumValue<DXM.BooleanValues>(value == true ? DXM.BooleanValues.One : DXM.BooleanValues.Zero);
  }

  #endregion

  #region Math OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Math OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The Math OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null, or null if element is null.</returns>
  public static Boolean? ConvertToBool(DXM.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      // ReSharper disable once InvokeAsExtensionMember
      return ConvertBoolValuesEnumToBool(openXmlElement.Val.Value);
    if (openXmlElement != null) return true;

    return null;
  }

  /// <summary>
  /// Creates a new instance of the specified Math OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXM.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXM.OnOffType? CreateMathOnOffType(Boolean? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXM.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = new DX.EnumValue<DXM.BooleanValues>(value == true ? DXM.BooleanValues.One : DXM.BooleanValues.Zero);
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Retrieves a boolean value from the text content of a OpenXmlLeafTextElement element.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement to check.</param>
  /// <returns>True for "true" or "1", false for "false" or "0", or null.</returns>
  public static bool? ConvertToBool(DX.OpenXmlLeafTextElement? element)
  {
    if (element?.Text != null)
    {
      var text = element.Text.ToLower();
      switch (text)
      {
        case "true": return true;
        case "false": return false;
        case "1": return true;
        case "0": return false;
      }
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement with text content "1" or "0" based on the boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The type of the element to create.</param>
  /// <returns>A new element with content "1" or "0", or null if value is null.</returns>
  public static DX.OpenXmlLeafTextElement? CreateOpenXmlLeafTextElement(bool? value, Type targetType)
  {
    if (value == null)
      return null;

    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    if (value == true)
    {
      element.Text = "1";
    }
    else if (value == false)
    {
      element.Text = "0";
    }
    return element;
  }

  #endregion


  #region Generic OpenXml boolean converter

  /// <summary>
  /// Converts a boolean value to an OpenXml value or element of the specified type.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The type of the OpenXml element to create.</param>
  /// <returns>An OpenXml element representing the boolean value, or null if the value is null.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public static object? ConvertToOpenXml(bool? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.IsEqualOrSubclassOf(typeof(DXW.EmptyType)))
      return ConvertBoolToDXWEmptyType(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DXO10W.EmptyType)))
      return ConvertBoolToDXO10WEmptyType(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DXD.EmptyType)))
      return ConvertBoolToDXDEmptyType(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.OnOffValue)))
      return ConvertBoolToOnOffValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DXW.OnOffOnlyValues)))
      return ConvertBoolToOnOffOnlyValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.EnumValue<DXW.OnOffOnlyValues>)))
      return ConvertBoolToOnOffOnlyValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.TrueFalseValue)))
      return ConvertBoolToTrueFalseValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.TrueFalseBlankValue)))
      return ConvertBoolToTrueFalseBlankValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DXW.OnOffType)))
      return CreateOnOffType(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DXW.OnOffOnlyType)))
      return CreateOnOffOnlyType(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DXO10W.OnOffValues)))
      return ConvertToOnOff10Value(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.EnumValue<DXO10W.OnOffValues>)))
      return CreateOnOff10EnumValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DXO10W.OnOffType)))
      return CreateOnOff10Type(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DXO13W.OnOffType)))
      return CreateOnOff13Type(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.BooleanValue)))
      return ConvertToMathBooleanValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DXM.BooleanValues)))
      return ConvertToMathBooleanValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.EnumValue<DXM.BooleanValues>)))
      return CreateMathOnOffEnumValue(value);
    if (targetType.IsEqualOrSubclassOf(typeof(DXM.OnOffType)))
      return CreateMathOnOffType(value, targetType);
    if (targetType.IsEqualOrSubclassOf(typeof(DX.OpenXmlLeafTextElement)))
      return CreateOpenXmlLeafTextElement(value, targetType);

    throw new NotSupportedException($"Conversion to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an OpenXml value or element to a boolean value.
  /// </summary>
  /// <param name="value">The OpenXml value or element to convert.</param>
  /// <returns>The boolean value represented by the element, or null if the element is null.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public static bool? ConvertFromOpenXml(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (value is DXW.EmptyType emptyTypeValue)
      return ConvertToBool(emptyTypeValue);
    if (value is DXO10W.EmptyType empty10TypeValue)
      return ConvertToBool(empty10TypeValue);
    if (value is DXD.EmptyType emptyDXDTypeValue)
      return ConvertToBool(emptyDXDTypeValue);
    if (value is DX.OnOffValue onOffValue)
      return ConvertToBool(onOffValue);
    if (value is DXW.OnOffOnlyValues offOnlyValue)
      return ConvertToBool(offOnlyValue);
    if (value is DX.EnumValue<DXW.OnOffOnlyValues> onOffOnlyEnumValue)
      return ConvertToBool(onOffOnlyEnumValue.Value);
    if (value is DXW.OnOffType onOffTypeValue)
      return ConvertToBool(onOffTypeValue);
    if (value is DXW.OnOffOnlyType onOffOnlyTypeValue)
      return ConvertToBool(onOffOnlyTypeValue);
    if (value is DX.TrueFalseValue trueFalseValue)
      return ConvertToBool(trueFalseValue);
    if (value is DX.TrueFalseBlankValue trueFalseBlankValue)
      return ConvertToBool(trueFalseBlankValue);
    if (value is DXO10W.OnOffValues onOff10Value)
      return ConvertToBool((DXO10W.OnOffValues?)onOff10Value);
    if (value is DX.EnumValue<DXO10W.OnOffValues> onOff10EnumValue)
      return ConvertToBool((DX.EnumValue<DXO10W.OnOffValues>?)onOff10EnumValue.Value);
    if (value is DXO10W.OnOffType onOff10TypeValue)
      return ConvertToBool(onOff10TypeValue);
    if (value is DXO13W.OnOffType onOff13TypeValue)
      return ConvertToBool(onOff13TypeValue);
    if (value is DX.BooleanValue booleanValue)
      return ConvertToBool(booleanValue);
    if (value is DXM.BooleanValues mathBooleanValues)
      return ConvertToBool(mathBooleanValues);
    if (value is DX.EnumValue<DXM.BooleanValues> mathBooleanEnumValue)
      return ConvertToBool(mathBooleanEnumValue.Value);
    if (value is DXM.OnOffType onOffMathTypeValue)
      return ConvertToBool(onOffMathTypeValue);
    if (value is DX.OpenXmlLeafTextElement openXmlLeafTextElement)
      return ConvertToBool(openXmlLeafTextElement);

    throw new NotSupportedException($"Conversion to type {sourceType} is not supported.");
  }

  #endregion
}