namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AlphaModulationFixed Class.
/// </summary>
public static class AlphaModulationFixedConverter
{
  /// <summary>
  /// Amount
  /// </summary>
  private static Int32? GetAmount(DXDraw.AlphaModulationFixed openXmlElement)
  {
    return openXmlElement?.Amount?.Value;
  }
  
  private static bool CmpAmount(DXDraw.AlphaModulationFixed openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Amount?.Value == value) return true;
    diffs?.Add(objName, "Amount", openXmlElement?.Amount?.Value, value);
    return false;
  }
  
  private static void SetAmount(DXDraw.AlphaModulationFixed openXmlElement, Int32? value)
  {
    openXmlElement.Amount = value;
  }
  
  public static DocumentModel.Drawings.AlphaModulationFixed? CreateModelElement(DXDraw.AlphaModulationFixed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaModulationFixed();
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AlphaModulationFixed? openXmlElement, DMDraws.AlphaModulationFixed? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAmount(openXmlElement, value.Amount, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaModulationFixed value)
    where OpenXmlElementType: DXDraw.AlphaModulationFixed, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AlphaModulationFixed openXmlElement, DMDraws.AlphaModulationFixed value)
  {
    SetAmount(openXmlElement, value?.Amount);
  }
}
