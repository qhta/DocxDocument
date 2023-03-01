namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// RunDate element converter.
/// </summary>
public static class RunDateConverter
{
  public static DMW.RunDate? CreateModelElement(DXW.DayShort? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunDate { Part = DMW.DatePart.Day, IsLong = false };
      return value;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.DayLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunDate { Part = DMW.DatePart.Day, IsLong = true };
      return value;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.MonthShort? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunDate { Part = DMW.DatePart.Month, IsLong = false };
      return value;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.MonthLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunDate { Part = DMW.DatePart.Month, IsLong = true };
      return value;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.YearShort? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunDate { Part = DMW.DatePart.Year, IsLong = false };
      return value;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.YearLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunDate { Part = DMW.DatePart.Year, IsLong = true };
      return value;
    }
    return null;
  }

  private static bool CheckModelElement(DX.OpenXmlElement? openXmlElement, DMW.RunDate? value, DMW.DatePart part, bool isLong, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!EnumValueConverter.CmpValue<DMW.DatePart, DMW.DatePart>(part, value.Part, diffs, objName, "Part"))
        ok = false;
      if (!BooleanValueConverter.CmpValue(isLong, value.IsLong, diffs, objName, "IsLong"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static bool CompareModelElement(DXW.DayShort? openXmlElement, DMW.RunDate? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.DatePart.Day, false, diffs, objName);

  public static bool CompareModelElement(DXW.DayLong? openXmlElement, DMW.RunDate? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.DatePart.Day, true, diffs, objName);

  public static bool CompareModelElement(DXW.MonthShort? openXmlElement, DMW.RunDate? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.DatePart.Month, false, diffs, objName);

  public static bool CompareModelElement(DXW.MonthLong? openXmlElement, DMW.RunDate? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.DatePart.Month, true, diffs, objName);

  public static bool CompareModelElement(DXW.YearShort? openXmlElement, DMW.RunDate? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.DatePart.Year, false, diffs, objName);

  public static bool CompareModelElement(DXW.YearLong? openXmlElement, DMW.RunDate? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.DatePart.Year, true, diffs, objName);

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.RunDate value)
  {
    switch (value.Part)
    {
      case DMW.DatePart.Day:
        if (value.IsLong)
          return new DXW.DayShort();
        else
          return new DXW.DayShort();
      case DMW.DatePart.Month:
        if (value.IsLong)
          return new DXW.MonthShort();
        else
          return new DXW.MonthShort();
      case DMW.DatePart.Year:
        if (value.IsLong)
          return new DXW.YearShort();
        else
          return new DXW.YearShort();
    }
    throw new InvalidOperationException($"Not supported date part {value.Part} in RunDateConverter.CreateOpenXmlElement");
  }

}
