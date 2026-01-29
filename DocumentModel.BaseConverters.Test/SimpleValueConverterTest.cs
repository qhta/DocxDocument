namespace DocumentModel.BaseConverters.Test;

public static class SimpleValueConverterTest
{
  private static readonly Assembly OpenXmlFrameworkAssembly = typeof(DocumentFormat.OpenXml.OpenXmlElement).Assembly;
  private static readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly;
  private static readonly Assembly SystemAssembly = typeof(System.String).Assembly;
  private static readonly Assembly UriAssembly = typeof(System.Uri).Assembly;


  private static readonly (Type modelType, Type otherType)[] SupportedTypes =
  [
    //( typeof(System.Boolean), "DXW.EmptyType" ),
    //( typeof(System.Boolean), "DXO10W.EmptyType" ),
    //( typeof(System.Boolean), "DXD.EmptyType" ),

    ( typeof(System.Boolean), typeof(DX.BooleanValue) ),
    ( typeof(System.Boolean), typeof(DX.OnOffValue) ),
    ( typeof(System.Boolean), typeof(DXW.OnOffOnlyValues) ),
    ( typeof(System.Boolean), typeof(DXO10W.OnOffValues) ),
    ( typeof(System.Boolean), typeof(DXW.OnOffType) ),
    ( typeof(System.Boolean), typeof(DXM.OnOffType) ),
    ( typeof(System.Boolean), typeof(DXO10W.OnOffType) ),
    ( typeof(System.Boolean), typeof(DXO13W.OnOffType) ),
    ( typeof(System.Boolean), typeof(DXW.OnOffOnlyType) ),
    ( typeof(System.Boolean), typeof(DXM.BooleanValues) ),
    ( typeof(System.Boolean), typeof(DX.TrueFalseValue) ),
    //( typeof(System.Boolean), "DX.TrueFalseBlankValue" ),

    //( typeof(System.Boolean), "DX.OpenXmlLeafElement { Val: DX.OnOffValue }" ),


 

    //( typeof(System.Int32), "DX.Int16Value" ),
    //( typeof(System.Int32), "DX.Int32Value" ),
    //( typeof(System.Int32), "DX.IntegerValue" ),
    //( typeof(System.Int32), "DX.OpenXmlLeafElement { Val: DX.Int32Value }" ),
    //( typeof(System.Int32), "DX.OpenXmlLeafElement { Val: DX.IntegerValue }" ),
    //( typeof(System.Int32), "DX.OpenXmlLeafTextElement" ),
    //( typeof(System.Int32), "DX.StringValue" ),
    //( typeof(System.Int32), "DXW.DecimalNumberType" ),
    //( typeof(System.Int32), "DXW.NonNegativeDecimalNumberType" ),
    //( typeof(System.Int32), "System.String" ),

    //( typeof(DocumentModel.Base64Binary), "DX.Base64BinaryValue" ),
    //( typeof(DocumentModel.EMU), "DX.Int64Value" ),
    //( typeof(DocumentModel.EMU), "DX.StringValue" ),
    //( typeof(DocumentModel.HalfPoints), "DXW.HpsMeasureType" ),
    //( typeof(DocumentModel.HexBinary), "DX.OpenXmlLeafElement { Val: DX.HexBinaryValue }" ),
    //( typeof(DocumentModel.HexBinary), "DX.OpenXmlLeafElement" ),
    //( typeof(DocumentModel.HexChar), "DX.HexBinaryValue" ),
    //( typeof(DocumentModel.HexInt), "DX.HexBinaryValue" ),
    //( typeof(DocumentModel.HexInt), "DXW.LongHexNumberType" ),
    //( typeof(DocumentModel.StringList), "DXW.StringType" ),
    //( typeof(DocumentModel.Twips), "DX.Int32Value" ),
    //( typeof(DocumentModel.Twips), "DX.StringValue" ),
    //( typeof(DocumentModel.Twips), "DX.UInt32Value" ),
    //( typeof(DocumentModel.Twips), "DXW.TwipsMeasureType" ),

    //( typeof(System.Byte), "DX.ByteValue" ),
    //( typeof(System.DateTime), "DX.DateTimeValue" ),
    //( typeof(System.DateTime), "System.DateTime" ),
    //( typeof(System.Decimal), "DX.DecimalValue" ),
    //( typeof(System.Guid), "DX.StringValue" ),
    //( typeof(System.Int16), "DX.Int16Value" ),
    //( typeof(System.Int16), "DX.OpenXmlLeafElement { Val: DX.Int16Value }" ),

    //( typeof(System.Int64), "DX.Int64Value" ),
    //( typeof(System.Int64), "DX.IntegerValue" ),
    //( typeof(System.Int64), "DX.OpenXmlLeafElement { Val: DX.IntegerValue }" ),
    //( typeof(System.Single), "DX.SingleValue" ),
    //( typeof(System.String), "DX.OpenXmlLeafElement { Val: DX.StringValue }" ),
    //( typeof(System.String), "DX.OpenXmlLeafTextElement" ),
    //( typeof(System.String), "DX.StringValue" ),
    //( typeof(System.String), "DXM.CharType" ),
    //( typeof(System.String), "DXW.String253Type" ),
    //( typeof(System.String), "DXW.String255Type" ),
    //( typeof(System.String), "DXW.StringType" ),
    //( typeof(System.String), "System.String" ),
    //( typeof(System.String), "System.Uri" ),
    //( typeof(System.UInt16), "DX.UInt16Value" ),
    //( typeof(System.UInt32), "DX.UInt32Value" ),
    //( typeof(System.UInt32), "DXW.StringType" ),
    //( typeof(System.UInt32), "DXW.UnsignedDecimalNumberType" ),
  ];


  private static readonly Dictionary<Type, Type> ConcreteTypesMap = new Dictionary<Type, Type>
  {
    { typeof(DXW.OnOffType), typeof(DXW.Active) },
    { typeof(DXO10W.OnOffType), typeof(DXO10W.ConflictMode) },
    { typeof(DXO13W.OnOffType), typeof(DXO13W.DefaultCollapsed) },
    { typeof(DXM.OnOffType), typeof(DXM.AlignScripts) },
    { typeof(DXW.OnOffOnlyType), typeof(DXW.Locked) },


    { typeof(DX.OpenXmlLeafTextElement), typeof(DXW.Text) },
    { typeof(DXM.CharType), typeof(DXM.SeparatorChar) },
    { typeof(DXW.StringType), typeof(DXW.ConnectString) },
    { typeof(DXW.DecimalNumberType), typeof(DXW.ActiveRecord) },
    { typeof(DXW.NonNegativeDecimalNumberType), typeof(DXW.StartNumberingValue) },
    { typeof(DXW.String255Type), typeof(DXW.DefaultTextBoxFormFieldString) },
  };

  private static readonly Dictionary<string, Type> OpenXmlLeafElementConcreteTypes = new Dictionary<string, Type>
  {
    { "DX.OnOffValue", typeof(DXW.Active) },
    { "DX.StringValue", typeof(DXM.MathFont) },
    { "DX.Int16Value", typeof(DXW.MaxLength) },
    { "DX.Int32Value", typeof(DXD.AlphaBiLevel) },
    { "DX.IntegerValue", typeof(DXM.ArgumentSize) },
    { "DX.HexBinaryValue", typeof(DXO10W.DocumentId) },
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
      Console.Write($"TestSimpleValueConverter with {type.Name} and {otherType.Name}");
      if (!TestSimpleValueConversion(type, otherType))
      {
        Console.WriteLine(" failed.");
        testResult = false;
      }
      else
        Console.WriteLine(" passed.");
    }
    return testResult;
  }

  /// <summary>
  /// Tests conversion between a model type and another type expression.
  /// Uses sample values to verify correct conversion in both directions.
  /// </summary>
  /// <param name="modelType">The model type to convert from and back</param>
  /// <param name="otherType">Target type to convert to</param>
  /// <returns></returns>
  public static bool TestSimpleValueConversion(Type modelType, Type otherType)
  {
    object[] testValues = GetTestData(modelType);
    if (otherType.IsAbstract)
      otherType = ConcreteTypesMap[otherType];

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
        var convertedValue = SimpleValueConverter.ConvertTo(testValue, otherType);
        var roundTripValue = SimpleValueConverter.ConvertFrom(convertedValue, modelType);
        if (!testValue.Equals(roundTripValue))
        {
          {
            Console.WriteLine($" - Conversion failed for value {testValue ?? "null"} of type {modelType.Name}");
            return false;
          }
        }
      }
      catch (Exception ex)
      {
        if (testValue is Int32 intValue && otherType == typeof(DX.Int16Value) && (intValue < Int16.MinValue || intValue > Int16.MaxValue))
        {
          // Expected exception for Int32 to Int16Value conversion
        }
        else
        if (modelType == typeof(Twips) && otherType == typeof(DX.UInt32Value) && (Int64)(Twips)testValue < 0)
        {
          // Expected exception for negative Twips to UInt32Value conversion
        }
        else
        {
          Console.WriteLine($" - Exception during conversion for value {testValue ?? "null"} of type {modelType.Name}: {ex.Message}");
          return false;
        }
      }
    }
    return true;
  }

  private static Type GetType(string otherTypeExpression)
  {
    string[] ss;
    if (otherTypeExpression.Contains("{"))
    {
      ss = otherTypeExpression.Split(['{', '}'], StringSplitOptions.RemoveEmptyEntries);
      if (ss.Length != 2)
        throw new InvalidOperationException($"Invalid other type expression: {otherTypeExpression}");
      var genericTypeName = ss[0].Trim();
      if (genericTypeName != "DX.OpenXmlLeafElement")
        throw new NotSupportedException($"Only DX.OpenXmlLeafElement with property initialization is supported, but got: {otherTypeExpression}");
      var propertyInitialization = ss[1];
      ss = propertyInitialization.Split(':', StringSplitOptions.RemoveEmptyEntries);
      if (ss.Length != 2)
        throw new InvalidOperationException($"Invalid other type expression: {otherTypeExpression}");

      var valueTypeName = ss[1].Trim();
      Type valueType = OpenXmlLeafElementConcreteTypes[valueTypeName];
      return valueType;
    }
    var fullTypeName = otherTypeExpression;

    //if (ConcreteTypesMap.TryGetValue(fullTypeName, out var concreteType))
    //  return concreteType;

    ss = fullTypeName.Split('.');
    if (ss.Length == 2)
    {
      var ns = ss[0].Trim();
      var typeName = ss[1].Trim();
      var fullNamespace = Namespaces.Map.GetValueOrDefault(ns, ns);
      var namespaceQualifiedName = $"{fullNamespace}.{typeName}";
      var type = OpenXmlAssembly.GetType(namespaceQualifiedName)
                 ?? OpenXmlFrameworkAssembly.GetType(namespaceQualifiedName)
                   ?? SystemAssembly.GetType(namespaceQualifiedName)
                    ?? UriAssembly.GetType(namespaceQualifiedName);

      if (type != null)
        return type;
    }
    throw new InvalidOperationException($"Cannot find type {fullTypeName}");
  }

  private static object[] GetTestData(Type testedType)
  {
    if (testedType == typeof(Boolean))
      return [true, false];
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
      return [Single.MinValue, -12345.6789f, 0f, 12345.6789f, Single.MaxValue, Single.NaN, Single.NegativeInfinity, Single.PositiveInfinity];
    if (testedType == typeof(Decimal))
      return [Decimal.MinValue, -1234567890.1234567890m, 0m, 1234567890.1234567890m, Decimal.MaxValue];
    if (testedType == typeof(DateTime))
      return [DateTime.MinValue, new DateTime(2000, 1, 1, 12, 30, 45), DateTime.Now, DateTime.MaxValue];
    if (testedType == typeof(Guid))
      return [Guid.Empty, Guid.NewGuid(), Guid.NewGuid()];
    if (testedType == typeof(DocumentModel.Base64Binary))
      return [new DocumentModel.Base64Binary([]),
        new DocumentModel.Base64Binary([1, 2, 3, 4, 5]),
        new DocumentModel.Base64Binary([255, 254, 253, 252])];
    if (testedType == typeof(DocumentModel.HexInt))
      return [new DocumentModel.HexInt(0), new DocumentModel.HexInt(305419896), new DocumentModel.HexInt(-1)];
    if (testedType == typeof(DocumentModel.Twips))
      return [new DocumentModel.Twips(0), new DocumentModel.Twips(1440), new DocumentModel.Twips(-720)];
    if (testedType == typeof(DocumentModel.EMU))
      return [new DocumentModel.EMU(0), new DocumentModel.EMU(914400), new DocumentModel.EMU(-457200)];
    if (testedType == typeof(DocumentModel.HexBinary))
      return [new DocumentModel.HexBinary([]),
        new DocumentModel.HexBinary([0xDE, 0xAD, 0xBE, 0xEF]),
        new DocumentModel.HexBinary([0x00, 0xFF, 0x7A, 0x3C])];
    if (testedType == typeof(DocumentModel.HalfPoints))
      return [new DocumentModel.HalfPoints(0), new DocumentModel.HalfPoints(72), new DocumentModel.HalfPoints(-36)];
    if (testedType == typeof(DocumentModel.HexChar))
      return [new DocumentModel.HexChar('A'), new DocumentModel.HexChar('z'), new DocumentModel.HexChar('0')];
    if (testedType == typeof(DocumentModel.StringList))
      return [new DocumentModel.StringList([]), new DocumentModel.StringList(["One", "Two", "Three"])];
    throw new NotSupportedException($"No test data defined for type {testedType.Name}");
  }
}