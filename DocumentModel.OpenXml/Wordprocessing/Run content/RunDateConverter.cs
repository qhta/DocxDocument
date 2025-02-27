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
      var model = new DMW.RunDate { Part = DMW.DateItem.Day, IsLong = false };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.DayLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DateItem.Day, IsLong = true };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.MonthShort? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DateItem.Month, IsLong = false };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.MonthLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DateItem.Month, IsLong = true };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.YearShort? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DateItem.Year, IsLong = false };
      return model;
    }
    return null;
  }

  public static DMW.RunDate? CreateModelElement(DXW.YearLong? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunDate { Part = DMW.DateItem.Year, IsLong = true };
      return model;
    }
    return null;
  }

  private static bool CheckModelElement(DX.OpenXmlElement? openXmlElement, DMW.RunDate? model, DMW.DateItem part, bool isLong, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!EnumValueConverter.CmpValue<DMW.DateItem, DMW.DateItem>(part, model.Part, diffs, objName, "Part"))
        ok = false;
      if (!BooleanValueConverter.CmpValue(isLong, model.IsLong, diffs, objName, "IsLong"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static bool CompareModelElement(DXW.DayShort? openXmlElement, DMW.RunDate? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.DateItem.Day, false, diffs, objName, propName);

  public static bool CompareModelElement(DXW.DayLong? openXmlElement, DMW.RunDate? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.DateItem.Day, true, diffs, objName, propName);

  public static bool CompareModelElement(DXW.MonthShort? openXmlElement, DMW.RunDate? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.DateItem.Month, false, diffs, objName, propName);

  public static bool CompareModelElement(DXW.MonthLong? openXmlElement, DMW.RunDate? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.DateItem.Month, true, diffs, objName, propName);

  public static bool CompareModelElement(DXW.YearShort? openXmlElement, DMW.RunDate? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.DateItem.Year, false, diffs, objName, propName);

  public static bool CompareModelElement(DXW.YearLong? openXmlElement, DMW.RunDate? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.DateItem.Year, true, diffs, objName, propName);

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.RunDate model)
  {
    switch (model.Part)
    {
      case DMW.DateItem.Day:
        if (model.IsLong)
          return new DXW.DayShort();
        else
          return new DXW.DayShort();
      case DMW.DateItem.Month:
        if (model.IsLong)
          return new DXW.MonthShort();
        else
          return new DXW.MonthShort();
      case DMW.DateItem.Year:
        if (model.IsLong)
          return new DXW.YearShort();
        else
          return new DXW.YearShort();
    }
    throw new InvalidOperationException($"Not supported date part {model.Part} in RunDateConverter.CreateOpenXmlParagraphContent");
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
