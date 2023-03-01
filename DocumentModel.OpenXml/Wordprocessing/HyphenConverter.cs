namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Hyphen element converter.
/// </summary>
public static class HyphenConverter
{
  public static DMW.Hyphen? CreateModelElement(DXW.NoBreakHyphen? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Hyphen{ Value = DMW.HyphenKind.NoBreakHyphen };
      return value;
    }
    return null;
  }

  public static DMW.Hyphen? CreateModelElement(DXW.SoftHyphen? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Hyphen{ Value = DMW.HyphenKind.SoftHyphen };
      return value;
    }
    return null;
  }

  private static bool CheckModelElement(DX.OpenXmlElement? openXmlElement, DMW.Hyphen? value, DMW.HyphenKind kind, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!EnumValueConverter.CmpValue<DMW.HyphenKind, DMW.HyphenKind>(kind, value.Value, diffs, objName, "Value"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static bool CompareModelElement(DXW.NoBreakHyphen? openXmlElement, DMW.Hyphen? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.HyphenKind.NoBreakHyphen, diffs, objName);

  public static bool CompareModelElement(DXW.SoftHyphen? openXmlElement, DMW.Hyphen? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.HyphenKind.SoftHyphen, diffs, objName);


  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.Hyphen value)
  {
    switch (value.Value)
    {
      case DMW.HyphenKind.NoBreakHyphen:
        return new DXW.NoBreakHyphen();
      case DMW.HyphenKind.SoftHyphen:
        return new DXW.SoftHyphen();
    }
    throw new InvalidOperationException($"Not supported hyphen value {value.Value} in HyphenConverter.CreateOpenXmlElement");
  }

}
