namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// ReferenceMark element converter.
/// </summary>
public static class SeparatorMarkConverter
{
  public static DMW.SeparatorMark? CreateModelElement(DXW.SeparatorMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SeparatorMark();
      return value;
    }
    return null;
  }

   public static DMW.SeparatorMark? CreateModelElement(DXW.ContinuationSeparatorMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SeparatorMark{ Continuation = true };
      return value;
    }
    return null;
  }

  private static bool CheckModelElement(DX.OpenXmlElement? openXmlElement, DMW.SeparatorMark? value, bool IsContinuation, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!BooleanValueConverter.CmpValue(IsContinuation, value.Continuation, diffs, objName, "Continuation"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static bool CompareModelElement(DXW.SeparatorMark? openXmlElement, DMW.SeparatorMark? value, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, value, false, diffs, objName, propName);

  public static bool CompareModelElement(DXW.ContinuationSeparatorMark? openXmlElement, DMW.SeparatorMark? value, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, value, true, diffs, objName, propName);

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.SeparatorMark value)
  {
    if (value.Continuation)
      return new DXW.ContinuationSeparatorMark();
    else
      return new DXW.SeparatorMark();
  }

  public static bool UpdateOpenXmlElement(DXW.SeparatorMark? openXmlElement, DMW.SeparatorMark? value)
    => true;

  public static bool UpdateOpenXmlElement(DXW.ContinuationSeparatorMark? openXmlElement, DMW.SeparatorMark? value)
    => true;

}
