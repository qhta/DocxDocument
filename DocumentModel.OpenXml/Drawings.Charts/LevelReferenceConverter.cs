namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LevelReference Class.
/// </summary>
public static class LevelReferenceConverter
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  private static String? GetSequenceOfReferences(DXO13DC.LevelReference openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO13DC.SequenceOfReferences>()?.Text;
  }
  
  private static bool CmpSequenceOfReferences(DXO13DC.LevelReference openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO13DC.SequenceOfReferences>()?.Text == value;
  }
  
  private static void SetSequenceOfReferences(DXO13DC.LevelReference openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.SequenceOfReferences>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO13DC.SequenceOfReferences { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.LevelReference? CreateModelElement(DXO13DC.LevelReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LevelReference();
      value.SequenceOfReferences = GetSequenceOfReferences(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13DC.LevelReference? openXmlElement, DMDC.LevelReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSequenceOfReferences(openXmlElement, value.SequenceOfReferences, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.LevelReference value)
    where OpenXmlElementType: DXO13DC.LevelReference, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DC.LevelReference openXmlElement, DMDC.LevelReference value)
  {
    SetSequenceOfReferences(openXmlElement, value?.SequenceOfReferences);
  }
}
