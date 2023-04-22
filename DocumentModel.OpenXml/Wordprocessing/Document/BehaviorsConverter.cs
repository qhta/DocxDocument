namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public static class BehaviorsConverter
{
  private static DMW.DocPartBehaviorKind? GetBehavior(DXW.Behaviors openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DocPartBehaviorValues, DMW.DocPartBehaviorKind>(openXmlElement.GetFirstChild<DXW.Behavior>()?.Val?.Value);
  }
  
  private static bool CmpBehavior(DXW.Behaviors openXmlElement, DMW.DocPartBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DXW.DocPartBehaviorValues, DMW.DocPartBehaviorKind>(openXmlElement.GetFirstChild<DXW.Behavior>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetBehavior(DXW.Behaviors openXmlElement, DMW.DocPartBehaviorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Behavior>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DXW.DocPartBehaviorValues, DMW.DocPartBehaviorKind>(itemElement, (DMW.DocPartBehaviorKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Behavior, DXW.DocPartBehaviorValues, DMW.DocPartBehaviorKind>((DMW.DocPartBehaviorKind)value));
  }
  
  public static DMW.Behaviors? CreateModelElement(DXW.Behaviors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Behaviors();
      value.Behavior = GetBehavior(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Behaviors? openXmlElement, DMW.Behaviors? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBehavior(openXmlElement, value.Behavior, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Behaviors value)
    where OpenXmlElementType: DXW.Behaviors, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Behaviors openXmlElement, DMW.Behaviors value)
  {
    SetBehavior(openXmlElement, value?.Behavior);
  }
}
