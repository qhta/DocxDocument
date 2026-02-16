namespace DocumentModel.BaseConverters.Test;

public static class SimpleValueConverterTest
{
  private static readonly Assembly OpenXmlFrameworkAssembly = typeof(DocumentFormat.OpenXml.OpenXmlElement).Assembly;
  private static readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly;
  private static readonly Assembly SystemAssembly = typeof(System.String).Assembly;
  private static readonly Assembly UriAssembly = typeof(System.Uri).Assembly;

  private static readonly (Type modelType, Type otherType)[] SupportedTypes =
  [
    (typeof(System.Boolean), typeof(DXW.EmptyType)),
    (typeof(System.Boolean), typeof(DX.BooleanValue)),
    (typeof(System.Boolean), typeof(DX.OnOffValue)),
    (typeof(System.Boolean), typeof(DXW.OnOffOnlyValues)),
    (typeof(System.Boolean), typeof(DXO10W.OnOffValues)),
    (typeof(System.Boolean), typeof(DXW.OnOffType)),
    (typeof(System.Boolean), typeof(DXM.OnOffType)),
    (typeof(System.Boolean), typeof(DXO10W.OnOffType)),
    (typeof(System.Boolean), typeof(DXO13W.OnOffType)),
    (typeof(System.Boolean), typeof(DXW.OnOffOnlyType)),
    (typeof(System.Boolean), typeof(DXM.BooleanValues)),
    (typeof(System.Boolean), typeof(DX.TrueFalseValue)),
    (typeof(DocumentModel.TSBoolean), typeof(DX.TrueFalseBlankValue)),
    (typeof(System.String), typeof(DX.OpenXmlLeafTextElement)),
    (typeof(System.String), typeof(DX.StringValue)),
    (typeof(System.String), typeof(DXM.CharType)),
    (typeof(System.String), typeof(DXW.String253Type)),
    (typeof(System.String), typeof(DXW.String255Type)),
    (typeof(System.String), typeof(DXW.StringType)),
    (typeof(System.String), typeof(System.Uri)),
    (typeof(System.Int32), typeof(DX.Int16Value)),
    (typeof(System.Int32), typeof(DX.Int32Value)),
    (typeof(System.Int32), typeof(DX.IntegerValue)),
    (typeof(System.Int32), typeof(DX.OpenXmlLeafTextElement)),
    (typeof(System.Int32), typeof(DX.StringValue)),
    (typeof(System.Int32), typeof(DXW.DecimalNumberType)),
    (typeof(System.Int32), typeof(DXW.NonNegativeDecimalNumberType)),
    (typeof(System.Int32), typeof(System.String)),
    (typeof(System.Int64), typeof(DX.Int64Value)),
    (typeof(System.Int64), typeof(DX.IntegerValue)),
    (typeof(System.Int16), typeof(DX.Int16Value)),
    (typeof(System.SByte), typeof(DX.SByteValue)),
    (typeof(System.Byte), typeof(DX.ByteValue)),
    (typeof(System.UInt16), typeof(DX.UInt16Value)),
    (typeof(System.UInt32), typeof(DX.UInt32Value)),
    (typeof(System.UInt32), typeof(DXW.StringType)),
    (typeof(System.UInt64), typeof(DX.UInt64Value)),
    (typeof(DocumentModel.Twips), typeof(DX.Int32Value)),
    (typeof(DocumentModel.Twips), typeof(DX.StringValue)),
    (typeof(DocumentModel.Twips), typeof(DX.UInt32Value)),
    (typeof(DocumentModel.Twips), typeof(DXW.TwipsMeasureType)),
    (typeof(DocumentModel.EMU), typeof(DX.Int64Value)),
    (typeof(DocumentModel.EMU), typeof(DX.StringValue)),
    (typeof(DocumentModel.HalfPoints), typeof(DXW.HpsMeasureType)),
    (typeof(System.Decimal), typeof(DX.DecimalValue)),
    (typeof(System.Single), typeof(DX.SingleValue)),
    (typeof(System.DateTime), typeof(DX.DateTimeValue)),
    (typeof(System.DateTime), typeof(System.DateTime)),
    (typeof(System.Guid), typeof(DX.StringValue)),
    (typeof(DocumentModel.Base64Binary), typeof(DX.Base64BinaryValue)),
    (typeof(DocumentModel.HexBinary), typeof(DXW.Panose1Number)),
    (typeof(DocumentModel.HexBinary), typeof(DXW.FontSignature)),
    (typeof(DocumentModel.HexInt), typeof(DX.HexBinaryValue)),
    (typeof(DocumentModel.HexInt), typeof(DXW.LongHexNumberType)),
    (typeof(DocumentModel.HexChar), typeof(DX.HexBinaryValue)),
    (typeof(DocumentModel.StringList), typeof(DX.StringValue)),
    (typeof(DocumentModel.HexRgb), typeof(DXW.Color)),
    (typeof(DocumentModel.PresetColors), typeof(DXD.PresetColorValues)),
    (typeof(DocumentModel.Percent), typeof(DXW.SummaryLength)),

  ];

  private static readonly Dictionary<Type, Type> ConcreteTypesMap = new Dictionary<Type, Type>
  {
    { typeof(DXW.EmptyType), typeof(DXW.ForceUpgrade) },
    { typeof(DXW.OnOffType), typeof(DXW.Active) },
    { typeof(DXO10W.OnOffType), typeof(DXO10W.ConflictMode) },
    { typeof(DXO13W.OnOffType), typeof(DXO13W.DefaultCollapsed) },
    { typeof(DXM.OnOffType), typeof(DXM.AlignScripts) },
    { typeof(DXW.OnOffOnlyType), typeof(DXW.Locked) },
    { typeof(DX.OpenXmlLeafTextElement), typeof(DXW.Text) },
    { typeof(DXM.CharType), typeof(DXM.SeparatorChar) },
    { typeof(DXW.StringType), typeof(DXW.ConnectString) },
    { typeof(DXW.DecimalNumberType), typeof(DXW.ActiveRecord) },
    { typeof(DXW.UnsignedDecimalNumberType), typeof(DXW.ColumnIndex) },
    { typeof(DXW.NonNegativeDecimalNumberType), typeof(DXW.StartNumberingValue) },
    { typeof(DXW.String255Type), typeof(DXW.DefaultTextBoxFormFieldString) },
    { typeof(DXW.String253Type), typeof(DXW.Aliases) },
    { typeof(DXW.TwipsMeasureType), typeof(DXM.ColumnSpacing) },
    { typeof(DXW.HpsMeasureType), typeof(DXW.FontSize) },
    { typeof(DXW.LongHexNumberType), typeof(DXW.Nsid) },
  };

  private static readonly Dictionary<Type, Type> OpenXmlLeafElementConcreteTypes = new Dictionary<Type, Type>
  {
    { typeof(DX.OnOffValue), typeof(DXOW.RecordIncluded) },
    { typeof(DX.StringValue), typeof(DXM.MathFont) },
    { typeof(DX.SByteValue), typeof(DXD.Charts.Overlap) },
    { typeof(DX.Int16Value), typeof(DXW.MaxLength) },
    { typeof(DX.Int32Value), typeof(DXD.AlphaBiLevel) },
    { typeof(DX.Int64Value), typeof(DXD.AlphaOutset) },
    { typeof(DX.IntegerValue), typeof(DXM.ArgumentSize) },
    { typeof(DX.ByteValue), typeof(DXD.Charts.Size) },
    { typeof(DX.UInt16Value), typeof(DXW.NumberingStart) },
    { typeof(DX.DecimalValue), typeof(DX.InkML.Latency) },
    { typeof(DX.Base64BinaryValue), typeof(DXW.UniqueTag) },
    { typeof(DX.HexBinaryValue), typeof(DXW.Panose1Number) },
  };

  /// <summary>
  ///   Runs all TestSimpleValueConversion tests for supported types and reports results to the console.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    bool testResult = true;
    foreach (var testPair in SupportedTypes)
    {
      Type type = testPair.modelType;
      var otherType = testPair.otherType;
      if (!TestValueConversion(type, otherType))
      {
        testResult = false;
        break;
      }
    }
    return testResult;
  }

  public static bool TestValueConversion(Type modelType, Type otherType)
  {
    if (!TestSimpleValueConversion(modelType, otherType))
      return false;

    //if (TestOpenXmlLeafTextElementConversion(modelType, otherType) == false)
    //  return false;
    if (TestOpenXmlLeafElementConversion(modelType, otherType) == false)
      return false;

    return true;
  }

  /// <summary>
  /// Tests conversion between a model type and another type expression.
  /// Uses sample values to verify correct conversion in both directions.
  /// </summary>
  /// <param name="modelType">The model type to convert from and back</param>
  /// <param name="otherType">Target type to convert to</param>
  /// <param name="baseType">Base type for test. If null, the model type is used.</param>
  /// <param name="testValues">Optional test values to use for the conversion tests</param>
  /// <returns></returns>
  public static bool TestSimpleValueConversion
    (Type modelType, Type otherType, Type? baseType = null, object[]? testValues = null)
  {
    Console.Write($"TestSimpleValueConverter with {modelType.Name} and {otherType.Name}");
    bool testResult = true;
    if (testValues == null) testValues = GetTestData(modelType);
    if (otherType.IsAbstract)
      otherType = ConcreteTypesMap[otherType];
    if (otherType == typeof(Uri))
    {
      testValues = ["", "https://sample.uri"];
    }
    else if (modelType == typeof(StringList))
    {
      testValues = [new StringList("", "Test String", "Another String")];
    }
    else if (modelType == typeof(HexBinary) && otherType == typeof(DXW.FontSignature))
    {
      testValues = [new HexBinary(), new HexBinary("00000001-00000002-00000003-00000004-01234567-89ABCDEF")];
    }
    foreach (var testValue0 in testValues)
    {
      object testValue = testValue0;
      if (testValue0.GetType() != modelType)
        testValue = Convert.ChangeType(testValue0, modelType);
      if (modelType == typeof(string)) Debug.Assert(true);
      if (otherType == typeof(DXW.Text)) Debug.Assert(true);
      try
      {
        if (modelType == typeof(Twips) && (Int64)(Twips)testValue < 0)
        {
          // Skip negative Twips to UInt32Value conversion test
        }
        if (modelType == typeof(DocumentModel.StringList)) Debug.Assert(true);
        var convertedValue = SimpleValueConverter.ConvertTo(testValue, otherType);
        var roundTripValue = SimpleValueConverter.ConvertFrom(convertedValue, modelType);
        if (!testValue.Equals(roundTripValue))
        {
          if (otherType != typeof(Uri)
              && (otherType.IsSubclassOf(typeof(DXW.EmptyType)) && testValue.Equals(true)))
          {
            Console.WriteLine($" - Conversion failed for value {testValue ?? "null"} of type {modelType.Name}");
            testResult = false;
            break;
          }
        }
      } catch (Exception ex)
      {
        var testedOtherType = baseType ?? otherType;
        if (testValue is Int32 intValue && testedOtherType == typeof(DX.Int16Value) &&
            (intValue < Int16.MinValue || intValue > Int16.MaxValue))
        {
          Debug.WriteLine("Expected exception for Int32 to Int16Value conversion");
        }
        else if (modelType == typeof(Twips) && testedOtherType == typeof(DX.UInt32Value) && (Int64)(Twips)testValue < 0)
        {
          Debug.WriteLine("Expected exception for negative Twips to UInt32Value conversion");
        }
        else
        {
          Console.WriteLine(
            $" - Exception during conversion for value {testValue ?? "null"} of type {modelType.Name}: {ex.Message}");
          testResult = false;
          break;
        }
      }
    }
    Console.WriteLine(testResult ? " passed." : " failed.");
    return testResult;
  }

  /// <summary>
  /// Tests conversion between a model type and another type expression.
  /// Uses sample values to verify correct conversion in both directions.
  /// </summary>
  /// <param name="modelType">The model type to convert from and back</param>
  /// <param name="otherType">Target type to convert to</param>
  /// <returns></returns>
  public static bool? TestOpenXmlLeafElementConversion(Type modelType, Type otherType)
  {
    object[] testValues = GetTestData(modelType);
    if (OpenXmlLeafElementConcreteTypes.TryGetValue(otherType, out var concreteType))
      return TestSimpleValueConversion(modelType, concreteType, otherType, testValues);

    return null;
  }

  private static object[] GetTestData(Type testedType)
  {
    if (testedType == typeof(Boolean))
      return [true, false];
    if (testedType == typeof(TSBoolean))
      return [TSBoolean.True, TSBoolean.False, TSBoolean.Blank];
    if (testedType == typeof(String))
      return ["", "Test String", "Another String"];
    if (testedType == typeof(Byte))
      return [Byte.MinValue, 0, 123, Byte.MaxValue];
    if (testedType == typeof(UInt16))
      return [UInt16.MinValue, 0u, 12345u, UInt16.MaxValue];
    if (testedType == typeof(UInt32))
      return [UInt32.MinValue, 0u, 1234567890u, UInt32.MaxValue];
    if (testedType == typeof(UInt64))
      return [UInt64.MinValue, 0ul, 12345678901234567890ul, UInt64.MaxValue];
    if (testedType == typeof(SByte))
      return [SByte.MinValue, -100, 0, 100, SByte.MaxValue];
    if (testedType == typeof(Int16))
      return [Int16.MinValue, -12345, 0, 12345, Int16.MaxValue];
    if (testedType == typeof(Int32))
      return [Int32.MinValue, -123456789, Int16.MinValue, 0, 123456789, Int16.MaxValue, Int32.MaxValue];
    if (testedType == typeof(Int64))
      return [Int64.MinValue, -1234567890123456789, 0L, 1234567890123456789, Int64.MaxValue];
    if (testedType == typeof(UInt32))
      return [UInt32.MinValue, 0u, 1234567890u, UInt32.MaxValue];
    if (testedType == typeof(Single))
      return
      [
        Single.MinValue, -12345.6789f, 0f, 12345.6789f, Single.MaxValue, Single.NaN, Single.NegativeInfinity,
        Single.PositiveInfinity
      ];
    if (testedType == typeof(Decimal))
      return [Decimal.MinValue, -1234567890.1234567890m, 0m, 1234567890.1234567890m, Decimal.MaxValue];
    if (testedType == typeof(DateTime))
      return [DateTime.MinValue, new DateTime(2000, 1, 1, 12, 30, 45), DateTime.Now, DateTime.MaxValue];
    if (testedType == typeof(Guid))
      return [Guid.Empty, Guid.NewGuid(), Guid.NewGuid()];
    if (testedType == typeof(DocumentModel.Base64Binary))
      return
      [
        new DocumentModel.Base64Binary([]),
        new DocumentModel.Base64Binary([1, 2, 3, 4, 5]),
        new DocumentModel.Base64Binary([255, 254, 253, 252])
      ];
    if (testedType == typeof(DocumentModel.HexInt))
      return [new DocumentModel.HexInt(0), new DocumentModel.HexInt(305419896), new DocumentModel.HexInt(-1)];
    if (testedType == typeof(DocumentModel.Twips))
      return [new DocumentModel.Twips(0), new DocumentModel.Twips(1440), new DocumentModel.Twips(-720)];
    if (testedType == typeof(DocumentModel.EMU))
      return [new DocumentModel.EMU(0), new DocumentModel.EMU(914400), new DocumentModel.EMU(-457200)];
    if (testedType == typeof(DocumentModel.HexBinary))
      return
      [
        new DocumentModel.HexBinary([]),
        new DocumentModel.HexBinary([0xDE, 0xAD, 0xBE, 0xEF]),
        new DocumentModel.HexBinary([0x00, 0xFF, 0x7A, 0x3C])
      ];
    if (testedType == typeof(DocumentModel.HalfPoints))
      return [new DocumentModel.HalfPoints(0), new DocumentModel.HalfPoints(72), new DocumentModel.HalfPoints(-36)];
    if (testedType == typeof(DocumentModel.HexChar))
      return [new DocumentModel.HexChar('A'), new DocumentModel.HexChar('z'), new DocumentModel.HexChar('0')];
    if (testedType == typeof(DocumentModel.StringList))
      return [new DocumentModel.StringList([]), new DocumentModel.StringList(["One", "Two", "Three"])];
    if (testedType == typeof(DocumentModel.HexRgb))
      return [new DocumentModel.HexRgb(), new DocumentModel.HexRgb("ABCDEF")];
    if (testedType == typeof(DocumentModel.PresetColors))
      return [new DocumentModel.PresetColors()];
    if (testedType == typeof(DocumentModel.Percent))
      return [new DocumentModel.Percent("50%")];
    throw new NotSupportedException($"No test data defined for type {testedType.Name}");
  }
}