using System.Xml.Linq;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Bibliography;

namespace DocumentModel.OpenXml;

public static class ListValueConverter
{
  #region ListOf<String> access methods
  public static ListOf<String>? GetValue(DX.ListValue<DX.StringValue>? element)
  {
    if (element != null)
    {
      var result = new ListOf<String>();
      foreach (var item in element) result.Add(StringValueConverter.GetValue(item));
    }
    return null;
  }

  public static bool CmpValue(DX.ListValue<DX.StringValue>? element, ListOf<String>? value, DiffList? diffs, string? objName)
  {
    if (element != null && value != null)
    {
      bool ok = true;
      var origElementsCount = element.Items.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, element.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var enumerator = value.GetEnumerator();
      int i=0;
      foreach (var origItem in element)
      {
        enumerator.MoveNext();
        var modelItem = enumerator.Current;
        if (origItem.Value != modelItem)
        {
          diffs?.Add(objName, element.GetType().Name + $"[{i++}]", origItem.Value, modelItem);
          ok = false;
        }
      }
      return ok;
    }
    if (element == null && value == null) return true;
    diffs?.Add(objName, element?.GetType().Name, element, value);
    return false;
  }

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
  public static ListOf<EnumKind>? GetValue<EnumType, EnumKind>(DX.ListValue<DX.EnumValue<EnumType>>? element)
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

  public static bool CmpValue<EnumType, EnumKind>(DX.ListValue<DX.EnumValue<EnumType>>? element, ListOf<EnumKind>? value, DiffList? diffs, string? objName)
    where EnumType : struct, IConvertible
    where EnumKind : struct, IConvertible
  {
    if (element != null && value != null)
    {
      bool ok = true;
      var origElementsCount = element.Items.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, element.GetType().Name + ".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var enumerator = value.GetEnumerator();
      foreach (var origItem in element)
      {
        enumerator.MoveNext();
        var modelItem = enumerator.Current;
        if (!EnumValueConverter.CmpValue<EnumType, EnumKind>(origItem.Value, modelItem, diffs, objName))
        {
          ok = false;
        }
      }
      return ok;
    }
    if (element == null && value == null) return true;
    diffs?.Add(objName, element?.GetType().Name, element, value);
    return false;
  }

  public static DX.ListValue<DX.EnumValue<EnumType>>? CreateListValue<EnumType, EnumKind>(ListOf<EnumKind> value)
    where EnumType : struct, IConvertible
    where EnumKind : struct, IConvertible
  {
    var resultList = new List<DX.EnumValue<EnumType>>();
    foreach (var item in value)
    {
      var itemObject = EnumValueConverter.CreateEnumValue<EnumType, EnumKind>(item);
      if (itemObject != null)
        resultList.Add(itemObject);
    }
    var element = new DX.ListValue<DX.EnumValue<EnumType>>(resultList);
    return element;
  }
  #endregion

  #region ListOf<Boolean> access methods
  public static ListOf<Boolean>? GetValue(DX.ListValue<DX.BooleanValue>? element)
  {
    if (element != null)
    {
      var result = new ListOf<Boolean>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  public static bool CmpValue(DX.ListValue<DX.BooleanValue>? element, ListOf<Boolean>? value, DiffList? diffs, string? objName)
  {
    if (element != null && value != null)
    {
      bool ok = true;
      var origElementsCount = element.Items.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, element.GetType().Name + ".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var enumerator = value.GetEnumerator();
      int i=0;
      foreach (var origItem in element)
      {
        enumerator.MoveNext();
        var modelItem = enumerator.Current;
        if (origItem.Value != modelItem)
        {
          diffs?.Add(objName, element.GetType().Name + $"[{i++}]", origItem.Value, modelItem);
          ok = false;
        }
      }
      return ok;
    }
    if (element == null && value == null) return true;
    diffs?.Add(objName, element?.GetType().Name, element, value);
    return false;
  }

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
  public static ListOf<Int32>? GetValue(DX.ListValue<DX.Int32Value>? element)
  {
    if (element != null)
    {
      var result = new ListOf<Int32>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  public static bool CmpValue(DX.ListValue<DX.Int32Value>? element, ListOf<Int32>? value, DiffList? diffs, string? objName)
  {
    if (element != null && value != null)
    {
      bool ok = true;
      var origElementsCount = element.Items.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, element.GetType().Name + ".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var enumerator = value.GetEnumerator();
      int i=0;
      foreach (var origItem in element)
      {
        enumerator.MoveNext();
        var modelItem = enumerator.Current;
        if (origItem.Value != modelItem)
        {
          diffs?.Add(objName, element.GetType().Name + $"[{i++}]", origItem.Value, modelItem);
          ok = false;
        }
      }
      return ok;
    }
    if (element == null && value == null) return true;
    diffs?.Add(objName, element?.GetType().Name, element, value);
    return false;
  }

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
  public static ListOf<UInt32>? GetValue(DX.ListValue<DX.UInt32Value>? element)
  {
    if (element != null)
    {
      var result = new ListOf<UInt32>();
      foreach (var item in element) result.Add(item);
    }
    return null;
  }

  public static bool CmpValue(DX.ListValue<DX.UInt32Value>? element, ListOf<UInt32>? value, DiffList? diffs, string? objName)
  {
    if (element != null && value != null)
    {
      bool ok = true;
      var origElementsCount = element.Items.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, element.GetType().Name + ".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var enumerator = value.GetEnumerator();
      int i = 0;
      foreach (var origItem in element)
      {
        enumerator.MoveNext();
        var modelItem = enumerator.Current;
        if (origItem.Value != modelItem)
        {
          diffs?.Add(objName, element.GetType().Name + $"[{i++}]", origItem.Value, modelItem);
          ok = false;
        }
      }
      return ok;
    }
    if (element == null && value == null) return true;
    diffs?.Add(objName, element?.GetType().Name, element, value);
    return false;
  }

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