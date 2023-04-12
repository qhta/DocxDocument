namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CarriageReturn"/> class from/to OpenXml converter.
/// </summary>
public static class CarriageReturnConverter
{
  public static DMW.CarriageReturn? CreateModelElement(DXW.CarriageReturn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CarriageReturn();
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.CarriageReturn? openXmlElement, DMW.CarriageReturn? value, DiffList? diffs, string? objName)
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

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.CarriageReturn value)
  {
    return new DXW.CarriageReturn();
  }

  public static bool UpdateOpenXmlElement(DXW.CarriageReturn? openXmlElement, DMW.CarriageReturn? value)
    => true;
}
