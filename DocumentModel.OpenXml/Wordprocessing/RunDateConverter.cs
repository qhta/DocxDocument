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
      var model = new DMW.RunDate { Part = DMW.DatePart.Day, IsLong = false };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.DayLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DatePart.Day, IsLong = true };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.MonthShort? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DatePart.Month, IsLong = false };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.MonthLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DatePart.Month, IsLong = true };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.YearShort? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DatePart.Year, IsLong = false };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.YearLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DatePart.Year, IsLong = true };
      return model;
    }
    return null;
  }

  private static bool CheckModelElement(DX.OpenXmlElement? openXmlElement, DMW.RunDate? model, DMW.DatePart part, bool isLong, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!EnumValueConverter.CmpValue<DMW.DatePart, DMW.DatePart>(part, model.Part, diffs, objName, "Part"))
        ok = false;
      if (!BooleanValueConverter.CmpValue(isLong, model.IsLong, diffs, objName, "IsLong"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static bool CompareModelElement(DXW.DayShort? openXmlElement, DMW.RunDate? model, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, model, DMW.DatePart.Day, false, diffs, objName);

  public static bool CompareModelElement(DXW.DayLong? openXmlElement, DMW.RunDate? model, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, model, DMW.DatePart.Day, true, diffs, objName);

  public static bool CompareModelElement(DXW.MonthShort? openXmlElement, DMW.RunDate? model, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, model, DMW.DatePart.Month, false, diffs, objName);

  public static bool CompareModelElement(DXW.MonthLong? openXmlElement, DMW.RunDate? model, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, model, DMW.DatePart.Month, true, diffs, objName);

  public static bool CompareModelElement(DXW.YearShort? openXmlElement, DMW.RunDate? model, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, model, DMW.DatePart.Year, false, diffs, objName);

  public static bool CompareModelElement(DXW.YearLong? openXmlElement, DMW.RunDate? model, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, model, DMW.DatePart.Year, true, diffs, objName);

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.RunDate model)
  {
    switch (model.Part)
    {
      case DMW.DatePart.Day:
        if (model.IsLong)
          return new DXW.DayShort();
        else
          return new DXW.DayShort();
      case DMW.DatePart.Month:
        if (model.IsLong)
          return new DXW.MonthShort();
        else
          return new DXW.MonthShort();
      case DMW.DatePart.Year:
        if (model.IsLong)
          return new DXW.YearShort();
        else
          return new DXW.YearShort();
    }
    throw new InvalidOperationException($"Not supported date part {model.Part} in RunDateConverter.CreateOpenXmlElement");
  }

  public static bool UpdateOpenXmlElement(DXW.DayShort? openXmlElement, DMW.RunDate? model)
    => true;

  public static bool UpdateOpenXmlElement(DXW.DayLong? openXmlElement, DMW.RunDate? model)
    => true;

  public static bool UpdateOpenXmlElement(DXW.MonthShort? openXmlElement, DMW.RunDate? model)
    => true;

  public static bool UpdateOpenXmlElement(DXW.MonthLong? openXmlElement, DMW.RunDate? model)
    => true;

  public static bool UpdateOpenXmlElement(DXW.YearShort? openXmlElement, DMW.RunDate? model)
    => true;

  public static bool UpdateOpenXmlElement(DXW.YearLong? openXmlElement, DMW.RunDate? model)
    => true;

}
