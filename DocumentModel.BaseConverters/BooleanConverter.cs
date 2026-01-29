namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for boolean values to/from Open XML.
/// </summary>
public static class BooleanConverter
{
  private static readonly ConversionMethodInfo[] supportedTypes =
  [
    new ConversionMethodInfo(typeof(DX.OnOffValue), nameof(ConvertFromOnOffValue), nameof(ConvertToOnOffValue)),
    new ConversionMethodInfo(typeof(DXW.OnOffOnlyValues), nameof(ConvertFromOnOffOnlyValues), nameof(ConvertToOnOffOnlyValues)),
    new ConversionMethodInfo(typeof(DXO10W.OnOffValues), nameof(ConvertFromO10WOnOffValues), nameof(ConvertToO10WOnOffValues)),
    new ConversionMethodInfo(typeof(DXW.OnOffType), nameof(ConvertFromOnOffType), nameof(ConvertToOnOffType)),
    new ConversionMethodInfo(typeof(DXM.OnOffType), nameof(ConvertFromMathOnOffType), nameof(ConvertToMathOnOffType)),
    new ConversionMethodInfo(typeof(DXO10W.OnOffType), nameof(ConvertFromO10WOnOffType), nameof(ConvertToO10WOnOffType)),
    new ConversionMethodInfo(typeof(DXO13W.OnOffType), nameof(ConvertFromO13WOnOffType), nameof(ConvertToO13WOnOffType)),
    new ConversionMethodInfo(typeof(DXW.OnOffOnlyType), nameof(ConvertFromOnOffOnlyType), nameof(ConvertToOnOffOnlyType)),
    new ConversionMethodInfo(typeof(DX.BooleanValue), nameof(ConvertFromBooleanValue), nameof(ConvertToBooleanValue)),
    new ConversionMethodInfo(typeof(DXM.BooleanValues), nameof(ConvertFromBooleanValues), nameof(ConvertToBooleanValues)),
    new ConversionMethodInfo(typeof(DX.TrueFalseValue), nameof(ConvertFromTrueFalseValue), nameof(ConvertToTrueFalseValue)),
    new ConversionMethodInfo(typeof(DX.EnumValue<DXW.OnOffOnlyValues>), nameof(ConvertFromEnumValueOfOnOffOnlyValues), nameof(ConvertToEnumValueOfOnOffOnlyValues)),
    new ConversionMethodInfo(typeof(DX.EnumValue<DXO10W.OnOffValues>), nameof(ConvertFromEnumValueOfO10WOnOffValues), nameof(ConvertToEnumValueOfO10WOnOffValues)),
    new ConversionMethodInfo(typeof(DX.EnumValue<DXM.BooleanValues>), nameof(ConvertFromEnumValueOfBooleanValues), nameof(ConvertToEnumValueOfBooleanValues)),
    new ConversionMethodInfo(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new ConversionMethodInfo(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new ConversionMethodInfo(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  static BooleanConverter()
  {
    //// Register conversion functions
    ConverterBase.RegisterConversionMethods(typeof(BooleanConverter), typeof(bool), supportedTypes, ConversionToMap, ConversionFromMap);
  }

  #region OnOffValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffValue openXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The OnOffValue openXmlElement to check.</param>
  /// <returns>A boolean representing the value, or null if the openXmlElement is null.</returns>
  private static Boolean? ConvertFromOnOffValue(DX.OnOffValue? openXmlElement)
  {
    if (openXmlElement == null) return null;

    return openXmlElement.Value;
  }

  /// <summary>
  /// Creates an OnOffValue using specified string representations for false and true.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="falseString">The string representation for false (default is "0").</param>
  /// <param name="trueString">The string representation for true (default is "1").</param>
  /// <returns>A new OnOffValue object, or null if the input value is null.</returns>
  private static DX.OnOffValue? ConvertToOnOffValue(Boolean? value)
  {
    if (value == null) return null;

    var val = (bool)value ? "1" : "0";
    return new DX.OnOffValue { InnerText = val };
  }

  #endregion

  #region OnOffOnlyValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffOnlyValues element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  private static Boolean? ConvertFromOnOffOnlyValues(DXW.OnOffOnlyValues? openXmlElement)
  {
    if (openXmlElement == null) return null;

    return openXmlElement == DXW.OnOffOnlyValues.On;
  }

  /// <summary>
  /// Creates an OnOffOnlyValues element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  private static DXW.OnOffOnlyValues? ConvertToOnOffOnlyValues(Boolean? value)
  {
    if (value == null) return null;
    if ((bool)value) return DXW.OnOffOnlyValues.On;

    return DXW.OnOffOnlyValues.Off;
  }

  #endregion

  #region EnumValue<OnOffOnlyValues> conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified EnumValue&lt;OnOffOnlyValues&gt; element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  private static Boolean? ConvertFromEnumValueOfOnOffOnlyValues(DX.EnumValue<DXW.OnOffOnlyValues>? openXmlElement)
  {
    if (openXmlElement == null) return null;

    return openXmlElement == DXW.OnOffOnlyValues.On;
  }

  /// <summary>
  /// Creates an EnumValue&lt;OnOffOnlyValues&gt; element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  private static DX.EnumValue<DXW.OnOffOnlyValues> ConvertToEnumValueOfOnOffOnlyValues(Boolean value)
  {
    if (value) return new DX.EnumValue<DXW.OnOffOnlyValues>(DXW.OnOffOnlyValues.On);

    return new DX.EnumValue<DXW.OnOffOnlyValues>(DXW.OnOffOnlyValues.Off);
  }

  #endregion

  #region TrueFalseValue conversion.

  /// <summary>
  /// Retrieves a boolean openXmlElement from the specified TrueFalseValue element.
  /// </summary>
  /// <param name="openXmlElement">The TrueFalseValue element to check.</param>
  /// <returns>True if the openXmlElement is On, otherwise null or false.</returns>
  private static Boolean? ConvertFromTrueFalseValue(DX.TrueFalseValue? openXmlElement)
  {
    if (openXmlElement == null) return null;

    return DX.TrueFalseValue.ToBoolean(openXmlElement);
  }

  /// <summary>
  /// Creates an TrueFalseValue element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>TrueFalseValue.On if true, TrueFalseValue.Off if false, otherwise null.</returns>
  private static DX.TrueFalseValue? ConvertToTrueFalseValue(Boolean? value)
  {
    if (value == null) return null;

    return new DX.TrueFalseValue(value);
  }

  #endregion

  #region DXW.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXW.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  private static Boolean? ConvertFromOnOffType(DXW.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;

    return openXmlElement.Val?.Value ?? true;
  }

  /// <summary>
  /// Creates a new instance of the specified DXW.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DXW.OnOffType? ConvertToOnOffType(Boolean? value, Type targetType)
  {
    if (value == null) return null;

    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXW.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXW.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region DXO13W.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXO13W.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  private static Boolean? ConvertFromO13WOnOffType(DXO13W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return true;

    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      return true;

    return (bool)enumVal;
  }

  /// <summary>
  /// Creates a new instance of the specified DXO13W.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXO13W.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DXO13W.OnOffType? ConvertToO13WOnOffType(Boolean? value, Type targetType)
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
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  private static Boolean? ConvertFromMathOnOffType(DXM.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      return true;
    if (enumVal == DXM.BooleanValues.True || enumVal == DXM.BooleanValues.One || enumVal == DXM.BooleanValues.On)
      return true;
    if (enumVal == DXM.BooleanValues.False || enumVal == DXM.BooleanValues.Zero || enumVal == DXM.BooleanValues.Off)
      return false;

    throw new InvalidOperationException("Unknown OnOffType value.");
  }

  /// <summary>
  /// Creates a new instance of the specified DXM.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXM.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>.</returns>
  private static DXM.OnOffType? ConvertToMathOnOffType(Boolean? value, Type targetType)
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
  private static Boolean? ConvertFromOnOffOnlyType(DXW.OnOffOnlyType? openXmlElement)
  {
    if (openXmlElement == null) return null;
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
  private static DXW.OnOffOnlyType? ConvertToOnOffOnlyType(Boolean? value, Type targetType)
  {
    if (value == null) return null;
    var element = (DXW.OnOffOnlyType)Activator.CreateInstance(targetType)!;
    element.Val = new DX.EnumValue<DXW.OnOffOnlyValues>((bool)value ? DXW.OnOffOnlyValues.On : DXW.OnOffOnlyValues.Off);
    return element;
  }

  #endregion

  #region Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean openXmlElement from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The OnOffValues to get boolean openXmlElement.</param>
  /// <returns>True for True/One, false for False/Zero.</returns>
  private static Boolean? ConvertFromO10WOnOffValues(DXO10W.OnOffValues? openXmlElement)
  {
    if (openXmlElement == null) return null;
    if (openXmlElement == DXO10W.OnOffValues.True || openXmlElement == DXO10W.OnOffValues.One)
      return true;
    if (openXmlElement == DXO10W.OnOffValues.False || openXmlElement == DXO10W.OnOffValues.Zero)
      return false;

    throw new InvalidOperationException($"Invalid openXmlElement {openXmlElement} in OnOffValues");
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding Open XML OnOffValues enumeration value.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If <see langword="true"/>, returns <c>OnOffValues.One</c>; if <see
  /// langword="false"/>, returns <c>OnOffValues.Zero</c>; if <see langword="null"/>, returns <see langword="null"/>.</param>
  /// <returns>A <c>DXO10W.OnOffValues</c> value representing the Boolean input.</returns>
  private static DXO10W.OnOffValues? ConvertToO10WOnOffValues(Boolean value) { return value == true ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero; }

  #endregion

  #region EnumValue of Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  private static Boolean? ConvertFromEnumValueOfO10WOnOffValues(DX.EnumValue<DXO10W.OnOffValues>? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var value = openXmlElement.Value;
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return true;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return false;

    throw new InvalidOperationException($"Invalid value {value} in OnOffValues");
  }

  /// <summary>
  /// Converts a boolean value to enum value of Office2010 Word OnOffValue.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>An <see cref="OnOffValues"/> corresponding to the specified Boolean value, or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DX.EnumValue<DXO10W.OnOffValues>? ConvertToEnumValueOfO10WOnOffValues(Boolean? value)
  {
    if (value == null) return null;
    return new DX.EnumValue<DXO10W.OnOffValues>((bool)value ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero);
  }

  #endregion

  #region Office2010 Word OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero.</returns>
  private static Boolean? ConvertFromO10WOnOffType(DXO10W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var value = openXmlElement.Val?.Value;
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return true;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return false;

    throw new InvalidOperationException($"Invalid value {value} in OnOffValues");
  }

  /// <summary>
  /// Creates a new instance of the specified OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>.</returns>
  private static DXO10W.OnOffType? ConvertToO10WOnOffType(Boolean? value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(bool)]) != null)
      return (DXO10W.OnOffType)Activator.CreateInstance(targetType, value == true)!;

    var element = (DXO10W.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = new DX.EnumValue<DXO10W.OnOffValues>(value == true ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero);
    return element;
  }

  #endregion

  #region BooleanValue conversion.

  /// <summary>
  /// Retrieves a boolean openXmlElement from the specified BooleanValue comparable simple openXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The openXmlElement to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  private static Boolean? ConvertFromBooleanValue(DX.BooleanValue? openXmlElement)
  {
    if (openXmlElement == null) return null;

    return openXmlElement;
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding OpenXml BooleanValue representation.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If null, the method returns null.</param>
  /// <returns>A DX.BooleanValue value representing the Boolean input</returns>
  private static DX.BooleanValue? ConvertToBooleanValue(Boolean? value)
  {
    return value.HasValue ? new DX.BooleanValue(value.Value) : null;
  }

  #endregion

  #region Math BooleanValues conversion.

  /// <summary>
  /// Retrieves a boolean openXmlElement from the specified Math BooleanValues enum openXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The openXmlElement to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  private static Boolean? ConvertFromBooleanValues(DXM.BooleanValues? openXmlElement)
  {
    if (openXmlElement == null) return null;
    if (openXmlElement == DXM.BooleanValues.True || openXmlElement == DXM.BooleanValues.On || openXmlElement == DXM.BooleanValues.One)
      return true;
    if (openXmlElement == DXM.BooleanValues.False || openXmlElement == DXM.BooleanValues.Off || openXmlElement == DXM.BooleanValues.Zero)
      return false;

    throw new InvalidOperationException("Invalid Math BooleanValues");
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding OpenXml Math BooleanValues representation.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If null, the method returns null.</param>
  /// <returns>A DXM.BooleanValues value representing the Boolean input: DXM.BooleanValues.One if <paramref name="value"/> is
  /// <see langword="true"/>, DXM.BooleanValues.Zero if <paramref name="value"/> is <see langword="false"/>, or null if
  /// <paramref name="value"/> is null.</returns>
  private static DXM.BooleanValues? ConvertToBooleanValues(Boolean? value)
  {
    if (value == null) return null;
    return (bool)value ? DXM.BooleanValues.One : DXM.BooleanValues.Zero;
  }

  #endregion

  #region EnumValue of Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  private static Boolean? ConvertFromEnumValueOfBooleanValues(DX.EnumValue<DXM.BooleanValues>? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var value = openXmlElement.Value;
    if (value == DXM.BooleanValues.True || value == DXM.BooleanValues.On || value == DXM.BooleanValues.One)
      return true;
    if (value == DXM.BooleanValues.False || value == DXM.BooleanValues.Off || value == DXM.BooleanValues.Zero)
      return false;

    throw new InvalidOperationException("Invalid Math BooleanValues");
  }

  /// <summary>
  /// Converts a boolean value to enum value of Office2010 Word OnOffValue.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>An <see cref="OnOffValues"/> corresponding to the specified Boolean value, or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DX.EnumValue<DXM.BooleanValues>? ConvertToEnumValueOfBooleanValues(Boolean? value)
  {
    if (value == null) return null;
    return new DX.EnumValue<DXM.BooleanValues>(value == true ? DXM.BooleanValues.One : DXM.BooleanValues.Zero);
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Retrieves a boolean value from the text content of a OpenXmlLeafTextElement element.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement to check.</param>
  /// <returns>True for "true" or "1", false for "false" or "0", or null.</returns>
  private static Boolean? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? element)
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
    throw new InvalidOperationException("Invalid OpenXmlLeafTextElement");
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement with text content "1" or "0" based on the boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The type of the element to create.</param>
  /// <returns>A new element with content "1" or "0".</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(bool? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    if ((bool)value)
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

  #region DXW.OpenXmlLeafElement conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DX.OpenXmlLeafElement element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlLeafElement to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  private static Boolean? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var valProp = openXmlElement.GetType().GetProperty("Val");
    if (valProp == null)
      throw new InvalidOperationException("The Val property is not found in " + openXmlElement.GetType().Name);
    
    var valValue = valProp.GetValue(openXmlElement)!;
    return ConvertFrom(valValue);
  }

  /// <summary>
  /// Creates a new instance of the specified DX.OpenXmlLeafElement and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OpenXmlLeafElement element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OpenXmlLeafElement to instantiate. Must be a type derived from DX.OpenXmlLeafElement.</param>
  /// <returns>A new instance of the specified OpenXmlLeafElement with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(Boolean? value, Type targetType)
  {
    if (value == null) return null;

    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType, value)!;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProp = targetType.GetValProperty();
    if (valProp == null)
      throw new InvalidOperationException("The Val property is not found in " + targetType.Name);

    var valValue = ConvertTo(value, valProp.PropertyType);
    valProp.SetValue(element, valValue);
    return element;
  }

  #endregion

  #region string conversion.

  /// <summary>
  /// Converts the specified string representation of a logical value to its nullable Boolean equivalent.
  /// </summary>
  /// <remarks>If <paramref name="value"/> is <see langword="null"/>, the method returns <see langword="true"/>.
  /// Any other input that does not match the accepted values results in <see langword="null"/>.</remarks>
  /// <param name="value">The string to convert. Accepts "true", "false", "1", or "0" (case-insensitive).</param>
  /// <returns>A nullable Boolean value: <see langword="true"/> if <paramref name="value"/> is "true" or "1"; <see
  /// langword="false"/> if <paramref name="value"/> is "false" or "0"; otherwise, <see langword="null"/>.</returns>
  private static Boolean? ConvertFromString(string? value)
  {
    if (value == null) return null;

    value = value.ToLower();
    if (value == "true" || value == "1")
      return true;
    if (value == "false" || value == "0")
      return false;

    throw new InvalidOperationException($"Invalid boolean string: {value}");
  }

  /// <summary>
  /// Converts the specified Boolean value to its string representation ("true" or "false").
  /// </summary>
  /// <param name="value">The value to convert</param>
  /// <returns>"true" or "false"</returns>
  private static string? ConvertToString(Boolean? value)
  {
    if (value == null) return null;
    return ((bool)value) ? "true" : "false";
  }

  #endregion

  #region Generic OpenXml boolean converter

  /// <summary>
  /// Converts a boolean value to an OpenXml value or element of the specified type.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The type of the OpenXml element to create.</param>
  /// <returns>An OpenXml element representing the boolean value.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public static object? ConvertTo(bool? value, Type targetType)
  {
    if (value == null) return null;

    if (ConversionToMap.TryGetValue((typeof(bool), targetType), out var conversionFunc))
    {
      return conversionFunc(value, targetType);
    }
    throw new NotSupportedException($"Conversion from Boolean to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an OpenXml value or element to a boolean value.
  /// </summary>
  /// <param name="value">The OpenXml value or element to convert.</param>
  /// <returns>The boolean value represented by the element.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public static bool? ConvertFrom(object? value)
  {
    if (value == null) return null;

    var sourceType = value.GetType();
    if (ConversionFromMap.TryGetValue((sourceType, typeof(bool)), out var conversionFunc))
    {
      return (bool)conversionFunc(value)!;
    }
    throw new NotSupportedException($"Conversion from type {sourceType} to Boolean is not supported.");
  }

  #endregion
}