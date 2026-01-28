namespace DocumentModel.BaseConverters.Test;

public static class SimpleValueConverterTest
{
  private static readonly Assembly OpenXmlFrameworkAssembly = typeof(DocumentFormat.OpenXml.OpenXmlElement).Assembly;
  private static readonly Assembly OpenXmlAssembly = typeof(DocumentFormat.OpenXml.Wordprocessing.Document).Assembly;
  private static readonly Assembly SystemAssembly = typeof(System.String).Assembly;
  private static readonly Assembly UriAssembly = typeof(System.Uri).Assembly;


  private static readonly (Type modelType, string otherTypeExpression)[] SupportedTypes  =
  [
    ( typeof(System.String), "DX.StringValue" ),
    ( typeof(System.String), "System.String" ),
    ( typeof(System.Int32), "System.String" ),
    ( typeof(System.DateTime), "System.DateTime" ),
    ( typeof(System.Int32), "DX.Int32Value" ),
    ( typeof(System.Guid), "DX.StringValue" ),
    ( typeof(System.Int32), "DX.OpenXmlLeafTextElement" ),
    ( typeof(System.Boolean), "DX.BooleanValue" ),
    ( typeof(System.UInt32), "DX.UInt32Value" ),
    ( typeof(System.Boolean), "DX.TrueFalseValue" ),
    ( typeof(System.Int64), "DX.IntegerValue" ),
    ( typeof(System.Single), "DX.SingleValue" ),
    ( typeof(System.Boolean), "DX.TrueFalseBlankValue" ),
    ( typeof(DocumentModel.Base64Binary), "DX.Base64BinaryValue" ),
    ( typeof(System.Decimal), "DX.DecimalValue" ),
    ( typeof(System.String), "DX.OpenXmlLeafTextElement" ),
    ( typeof(System.String), "System.Uri" ),
    ( typeof(System.String), "DXM.CharType" ),
    ( typeof(System.Int32), "DX.OpenXmlLeafElement { Val: DX.IntegerValue }" ),
    ( typeof(System.Boolean), "DXM.OnOffType" ),
    ( typeof(System.DateTime), "DX.DateTimeValue" ),
    ( typeof(DocumentModel.HexInt), "DX.HexBinaryValue" ),
    ( typeof(System.Boolean), "DX.OnOffValue" ),
    ( typeof(DocumentModel.Twips), "DX.UInt32Value" ),
    ( typeof(System.String), "DXW.StringType" ),
    ( typeof(DocumentModel.Twips), "DX.Int32Value" ),
    ( typeof(DocumentModel.HexChar), "DX.HexBinaryValue" ),
    ( typeof(System.Int32), "DXW.DecimalNumberType" ),
    ( typeof(System.Int32), "DX.OpenXmlLeafElement { Val: DX.Int32Value }" ),
    ( typeof(System.String), "DXW.String255Type" ),
    ( typeof(System.Int16), "DX.OpenXmlLeafElement { Val: DX.Int16Value }" ),
    ( typeof(System.String), "DX.OpenXmlLeafElement { Val: DX.StringValue }" ),
    ( typeof(DocumentModel.StringList), "DXW.StringType" ),
    ( typeof(DocumentModel.HexBinary), "DX.OpenXmlLeafElement { Val: DX.HexBinaryValue }" ),
    ( typeof(System.Boolean), "DXW.OnOffType" ),
    ( typeof(DocumentModel.HexBinary), "DX.OpenXmlLeafElement" ),
    ( typeof(System.Int32), "DX.IntegerValue" ),
    ( typeof(System.UInt32), "DXW.StringType" ),
    ( typeof(DocumentModel.Twips), "DXW.TwipsMeasureType" ),
    ( typeof(System.Boolean), "DXW.OnOffOnlyType" ),
    ( typeof(System.UInt32), "DXW.UnsignedDecimalNumberType" ),
    ( typeof(System.Boolean), "DX.OpenXmlLeafElement { Val: DX.OnOffValue }" ),
    ( typeof(System.Int64), "DX.OpenXmlLeafElement { Val: DX.IntegerValue }" ),
    ( typeof(DocumentModel.HexInt), "DXW.LongHexNumberType" ),
    ( typeof(System.String), "DXW.String253Type" ),
    ( typeof(System.Int32), "DXW.NonNegativeDecimalNumberType" ),
    ( typeof(DocumentModel.HalfPoints), "DXW.HpsMeasureType" ),
    ( typeof(System.Boolean), "DXO10W.EmptyType" ),
    ( typeof(System.Boolean), "DXO13W.OnOffType" ),
    ( typeof(System.Int16), "DX.Int16Value" ),
    ( typeof(System.Byte), "DX.ByteValue" ),
    ( typeof(System.UInt16), "DX.UInt16Value" ),
    ( typeof(DocumentModel.Twips), "DX.StringValue" ),
    ( typeof(System.Int32), "DX.Int16Value" ),
    ( typeof(System.Int32), "DX.StringValue" ),
    ( typeof(System.Int64), "DX.Int64Value" ),
    ( typeof(DocumentModel.EMU), "DX.StringValue" ),
    ( typeof(DocumentModel.EMU), "DX.Int64Value" ),
  ];


  private static readonly Dictionary<string, Type> OpenXmlLeafElementConcreteTypes = new Dictionary<string, Type>
  {
    { "DX.Int32Value", typeof(DXD.AlphaBiLevel) },
    { "DX.IntegerValue", typeof(DXD.AlphaBiLevel) },

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
      var otherTypeExpression = testPair.otherTypeExpression;
      Console.Write($"TestSimpleValueConverter with {type.Name} and {otherTypeExpression}");
      if (!TestSimpleValueConversion(type, otherTypeExpression))
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
  /// <param name="otherTypeExpression">It can be a simple type name
  /// or type name with property initialization consisting of a single property name and a type of this property</param>
  /// <returns></returns>
  public static bool TestSimpleValueConversion(Type modelType, string otherTypeExpression)
  {
    Type otherType = GetType(otherTypeExpression);
    object[] testValues = GetTestData(modelType);
    //object[] convertedValues = GetTestData(otherType);

    foreach (var testValue in testValues)
    {
      if (modelType == typeof(string)) Debug.Assert(true);
      if (otherType == typeof(DXW.Text)) Debug.Assert(true);
      var convertedValue = SimpleValueConverter.ChangeType(testValue, otherType);
      var roundTripValue = SimpleValueConverter.ChangeType(convertedValue, modelType);
      if (!testValue.Equals(roundTripValue))
      {
        Console.WriteLine($" - Conversion failed for value {testValue ?? "null"} of type {modelType.Name}");
        return false;
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

    if (fullTypeName == "DX.OpenXmlLeafTextElement")
      return typeof(DXW.Text);
    if (fullTypeName == "DXM.CharType")
      return typeof(DXM.SeparatorChar);
    if (fullTypeName == "DXM.OnOffType")
      return typeof(DXM.AlignScripts);

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
      return [Int32.MinValue, -123456789, 0, 123456789, Int32.MaxValue];
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
      return [new DocumentModel.Base64Binary(new byte[] { }),
        new DocumentModel.Base64Binary(new byte[] { 1, 2, 3, 4, 5 }),
        new DocumentModel.Base64Binary(new byte[] { 255, 254, 253, 252 })];
    if (testedType == typeof(DocumentModel.HexInt))
      return [new DocumentModel.HexInt(0), new DocumentModel.HexInt(305419896), new DocumentModel.HexInt(-1)];
    if (testedType == typeof(DocumentModel.Twips))
      return [new DocumentModel.Twips(0), new DocumentModel.Twips(1440), new DocumentModel.Twips(-720)];
    //if (testedType == typeof(DocumentModel.StringList))
    //  return [new DocumentModel.StringList(new string[] { }), new DocumentModel.StringList(new string[] { "One", "Two", "Three" })];
    throw new NotSupportedException($"No test data defined for type {testedType.Name}");
  }
}