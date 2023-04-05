namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Simple run element converter
/// </summary>
public static class SimpleRunElementConverter
{
  public static DMW.PageNumber? CreateModelElement(DXW.PageNumber? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PageNumber();
      return value;
    }
    return null;
  }

  public static DMW.CarriageReturn? CreateModelElement(DXW.CarriageReturn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CarriageReturn();
      return value;
    }
    return null;
  }

  public static DMW.TabChar? CreateModelElement(DXW.TabChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TabChar();
      return value;
    }
    return null;
  }

  private static bool CheckModelElement<ElementType>(DX.OpenXmlElement? openXmlElement, ElementType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static bool CompareModelElement(DXW.PageNumber? openXmlElement, DMW.PageNumber? value, DiffList? diffs, string? objName)
    => CheckModelElement<DMW.PageNumber>(openXmlElement, value, diffs, objName);

  public static bool CompareModelElement(DXW.CarriageReturn? openXmlElement, DMW.CarriageReturn? value, DiffList? diffs, string? objName)
    => CheckModelElement<DMW.CarriageReturn>(openXmlElement, value, diffs, objName);

  public static bool CompareModelElement(DXW.TabChar? openXmlElement, DMW.TabChar? value, DiffList? diffs, string? objName)
    => CheckModelElement<DMW.TabChar>(openXmlElement, value, diffs, objName);

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.IRunContent value)
  {
    if (value is DMW.PageNumber)
        return new DXW.PageNumber();
    if (value is DMW.CarriageReturn)
        return new DXW.CarriageReturn();
    if (value is DMW.TabChar)
        return new DXW.TabChar();
    throw new InvalidOperationException($"Not supported type {value.GetType()} in SimpleRunElementConverter.CreateOpenXmlParagraphElement");
  }

  public static bool UpdateOpenXmlElement(DXW.PageNumber? openXmlElement, DMW.PageNumber? value)
    => true;

  public static bool UpdateOpenXmlElement(DXW.CarriageReturn? openXmlElement, DMW.CarriageReturn? value)
    => true;

  public static bool UpdateOpenXmlElement(DXW.TabChar? openXmlElement, DMW.TabChar? value)
    => true;


}
