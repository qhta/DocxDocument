namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.ParagraphProperties"/> class from/to OpenXml converter.
/// </summary>
public static class ParagraphPropertiesConverter
{
  #region Justification. conversion.
  private static DMM.JustificationKind? GetJustification(DXM.ParagraphProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.JustificationValues, DMM.JustificationKind>(openXmlElement.GetFirstChild<DXM.Justification>()?.Val?.Value);
  }
  
  private static bool CmpJustification(DXM.ParagraphProperties openXmlElement, DMM.JustificationKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.JustificationValues, DMM.JustificationKind>(openXmlElement.GetFirstChild<DXM.Justification>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetJustification(DXM.ParagraphProperties openXmlElement, DMM.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Justification>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.JustificationValues, DMM.JustificationKind>(itemElement, (DMM.JustificationKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXM.Justification, DocumentFormat.OpenXml.Math.JustificationValues, DMM.JustificationKind>((DMM.JustificationKind)value));
  }
  #endregion

  #region ParagraphProperties model conversion.
  public static DMM.ParagraphProperties? CreateModelElement(DXM.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.ParagraphProperties();
      model.Justification = GetJustification(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.ParagraphProperties? openXmlElement, DMM.ParagraphProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpJustification(openXmlElement, model.Justification, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.ParagraphProperties model)
    where OpenXmlElementType: DXM.ParagraphProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.ParagraphProperties openXmlElement, DMM.ParagraphProperties model)
  {
    SetJustification(openXmlElement, model?.Justification);
  }
  #endregion
}
