namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines conversion methods for the following OpenXMlElements:
/// HyperlinkRuby, CustomXmlRuby, SimpleFieldsRuby, SdtRunRuby
/// </summary>
public static class RubyContentElementsConverter
{
  public static DMW.IRubyContent? CreateModelElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.HyperlinkRuby hyperlinkRuby)
      return DMXW.HyperlinkRubyConverter.CreateModelElement(hyperlinkRuby);
    if (openXmlElement is DXW.CustomXmlRuby customXmlRuby)
      return DMXW.CustomXmlRubyConverter.CreateModelElement(customXmlRuby);
    if (openXmlElement is DXW.SimpleFieldRuby simpleField)
      return DMXW.SimpleFieldRubyConverter.CreateModelElement(simpleField);
    if (openXmlElement is DXW.SdtRunRuby sdtRun)
      return DMXW.SdtRunRubyConverter.CreateModelElement(sdtRun);
    return null;
  }

  public static bool? CompareModelElement(DX.OpenXmlElement? openXmlElement, DMW.IRubyContent? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.HyperlinkRuby hyperlinkRuby && model is DMW.HyperlinkRuby hyperlinkRubyModel)
        return DMXW.HyperlinkRubyConverter.CompareModelElement(hyperlinkRuby, hyperlinkRubyModel, diffs, objName, propName);
      if (openXmlElement is DXW.CustomXmlRuby customXmlRuby && model is DMW.CustomXmlRuby customXmlRubyModel)
        return DMXW.CustomXmlRubyConverter.CompareModelElement(customXmlRuby, customXmlRubyModel, diffs, objName, propName);
      if (openXmlElement is DXW.SimpleFieldRuby simpleFieldRuby && model is DMW.SimpleFieldRuby simpleFieldRubyModel)
        return DMXW.SimpleFieldRubyConverter.CompareModelElement(simpleFieldRuby, simpleFieldRubyModel, diffs, objName, propName);
      if (openXmlElement is DXW.SdtRunRuby sdtRunRuby && model is DMW.SdtRunRuby sdtRunRubyModel)
        return DMXW.SdtRunRubyConverter.CompareModelElement(sdtRunRuby, sdtRunRubyModel, diffs, objName, propName);
      return null;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement? CreateOpenXmlElement(DMW.IRubyContent? model)
  {
    if (model is DMW.HyperlinkRuby hyperlinkRuby)
      return DMXW.HyperlinkRubyConverter.CreateOpenXmlElement(hyperlinkRuby);
    if (model is DMW.CustomXmlRuby customXmlRuby)
      return DMXW.CustomXmlRubyConverter.CreateOpenXmlElement(customXmlRuby);
    if (model is DMW.SimpleFieldRuby simpleFieldRuby)
      return DMXW.SimpleFieldRubyConverter.CreateOpenXmlElement(simpleFieldRuby);
    if (model is DMW.SdtRunRuby sdtRunRuby)
      return DMXW.SdtRunRubyConverter.CreateOpenXmlElement(sdtRunRuby);
    return null;
  }

    public static bool? UpdateOpenXmlElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXW.HyperlinkRuby hyperlinkRuby && model is DMW.HyperlinkRuby hyperlinkRubyModel)
        return DMXW.HyperlinkRubyConverter.UpdateOpenXmlElement(hyperlinkRuby, hyperlinkRubyModel);
      if (openXmlElement is DXW.CustomXmlRuby customXmlRuby && model is DMW.CustomXmlRuby customXmlRubyModel)
        return DMXW.CustomXmlRubyConverter.UpdateOpenXmlElement(customXmlRuby, customXmlRubyModel);
      if (openXmlElement is DXW.SimpleFieldRuby simpleFieldRuby && model is DMW.SimpleFieldRuby simpleFieldRubyModel)
        return DMXW.SimpleFieldRubyConverter.UpdateOpenXmlElement(simpleFieldRuby, simpleFieldRubyModel);
      if (openXmlElement is DXW.SdtRunRuby sdtRunRuby && model is DMW.SdtRunRuby sdtRunRubyModel)
        return DMXW.SdtRunRubyConverter.UpdateOpenXmlElement(sdtRunRuby, sdtRunRubyModel);
    }
    return false;
  }

}
