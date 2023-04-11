using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Hyphen element converter.
/// </summary>
public static class HyphenConverter
{
  public static Hyphen? CreateModelElement(DXW.NoBreakHyphen? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Hyphen{ Value = DMW.HyphenKind.NoBreakHyphen };
      return model;
    }
    return null;
  }

  public static Hyphen? CreateModelElement(DXW.SoftHyphen? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Hyphen{ Value = DMW.HyphenKind.SoftHyphen };
      return model;
    }
    return null;
  }

  private static bool CheckModelElement(DX.OpenXmlElement? openXmlElement, Hyphen? model, DMW.HyphenKind kind, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!EnumValueConverter.CmpValue<DMW.HyphenKind>(kind, model.Value, diffs, objName, "Type"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static bool CompareModelElement(DXW.NoBreakHyphen? openXmlElement, Hyphen? model, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, model, DMW.HyphenKind.NoBreakHyphen, diffs, objName);

  public static bool CompareModelElement(DXW.SoftHyphen? openXmlElement, Hyphen? model, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, model, DMW.HyphenKind.SoftHyphen, diffs, objName);


  public static DX.OpenXmlElement CreateOpenXmlElement(Hyphen model)
  {
    switch (model.Value)
    {
      case DMW.HyphenKind.NoBreakHyphen:
        return new DXW.NoBreakHyphen();
      case DMW.HyphenKind.SoftHyphen:
        return new DXW.SoftHyphen();
    }
    throw new InvalidOperationException($"Not supported hyphen model {model.Value} in HyphenConverter.CreateOpenXmlParagraphContent");
  }

    public static bool UpdateOpenXmlElement(DXW.NoBreakHyphen openXmlElement, Hyphen model)
     => true;

  public static bool UpdateOpenXmlElement(DXW.SoftHyphen openXmlElement, Hyphen model)
     => true;
}
