namespace DocumentModel.OpenXml;

public static class ListValueConverter
{
  public static ListOf<String>? GetValue(ListValue<StringValue>? element)
  {
    if (element != null)
    {
      var result = new ListOf<String>();
      foreach (var item in element) result.Add(StringValueConverter.GetValue(item));
    }
    return null;
  }

  public static ListOf<EnumKind>? GetValue<EnumType, EnumKind>(ListValue<EnumValue<EnumType>>? element)
    where EnumType : struct, IConvertible
    where EnumKind : struct, IConvertible
  {
    if (element != null)
    {
      var result = new ListOf<EnumKind>();
      foreach (var item in element)
      {
        var itemValue = EnumValueConverter.GetValue<EnumType, EnumKind>(item);
        if (itemValue != null)
          result.Add((EnumKind)itemValue);
      }
    }
    return null;
  }

  public static ListOf<Boolean>? GetValue(ListValue<BooleanValue>? element)
  {
    if (element != null)
    {
      var result = new ListOf<Boolean>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  public static ListOf<Int32>? GetValue(ListValue<Int32Value>? element)
  {
    if (element != null)
    {
      var result = new ListOf<Int32>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  public static ListOf<UInt32>? GetValue(ListValue<UInt32Value>? element)
  {
    if (element != null)
    {
      var result = new ListOf<UInt32>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  public static ListValue<StringValue>? CreateListValue<OpenXmlElementType>(ListOf<String> value)
  {
    var resultList = new List<StringValue>();
    foreach (var item in value)
    {
      var itemObject = new StringValue(item);
      resultList.Add(itemObject);
    }
    var element = new ListValue<StringValue>(resultList);
    return element;
  }

  public static ListValue<EnumValue<EnumType>>? CreateListValue<EnumType, EnumKind>(ListOf<EnumKind> value)
    where EnumType : struct, IConvertible
    where EnumKind : struct, IConvertible
  {
    var resultList = new List<EnumValue<EnumType>>();
    foreach (var item in value)
    {
      var itemObject = EnumValueConverter.CreateEnumValue<EnumType, EnumKind>(item);
      if (itemObject != null)
        resultList.Add(itemObject);
    }
    var element = new ListValue<EnumValue<EnumType>>(resultList);
    return element;
  }

  public static ListValue<BooleanValue>? CreateListValue<OpenXmlElementType>(ListOf<Boolean> value)
  {
    var resultList = new List<BooleanValue>();
    foreach (var item in value)
    {
      var itemObject = new BooleanValue(item);
      resultList.Add(itemObject);
    }
    var element = new ListValue<BooleanValue>(resultList);
    return element;
  }

  public static ListValue<Int32Value>? CreateListValue<OpenXmlElementType>(ListOf<Int32> value)
  {
    var resultList = new List<Int32Value>();
    foreach (var item in value)
    {
      var itemObject = new Int32Value(item);
      resultList.Add(itemObject);
    }
    var element = new ListValue<Int32Value>(resultList);
    return element;
  }

  public static ListValue<UInt32Value>? CreateListValue<OpenXmlElementType>(ListOf<UInt32> value)
  {
    var resultList = new List<UInt32Value>();
    foreach (var item in value)
    {
      var itemObject = new UInt32Value(item);
      resultList.Add(itemObject);
    }
    var element = new ListValue<UInt32Value>(resultList);
    return element;
  }
}