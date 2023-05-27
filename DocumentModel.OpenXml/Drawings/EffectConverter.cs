namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DMD.Fill"/> abstract class from/to OpenXml converter.
/// </summary>
public static class EffectConverter
{
  #region Reference conversion.
  private static String? GetReference(DXD.Effect openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Reference);
  }
  
  private static bool CmpReference(DXD.Effect openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Reference, value, diffs, objName, "Reference");
  }
  
  private static void SetReference(DXD.Effect openXmlElement, String? value)
  {
    openXmlElement.Reference = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Effect model conversion.
  public static DMD.Effect? CreateModelElement(DXD.Effect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.Effect();
      model.Reference = GetReference(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Effect? openXmlElement, DMD.Effect? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpReference(openXmlElement, model.Reference, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Effect model)
    where OpenXmlElementType: DXD.Effect, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Effect openXmlElement, DMD.Effect model)
  {
    SetReference(openXmlElement, model?.Reference);
  }
  #endregion
}
