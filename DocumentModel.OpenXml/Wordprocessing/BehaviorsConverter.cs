namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public static class BehaviorsConverter
{
  private static DMW.DocPartBehaviorKind? GetBehavior(DXW.Behaviors openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues, DMW.DocPartBehaviorKind>(openXmlElement.GetFirstChild<DXW.Behavior>()?.Val?.Value);
  }
  
  private static bool CmpBehavior(DXW.Behaviors openXmlElement, DMW.DocPartBehaviorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues, DMW.DocPartBehaviorKind>(openXmlElement.GetFirstChild<DXW.Behavior>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBehavior(DXW.Behaviors openXmlElement, DMW.DocPartBehaviorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Behavior>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.Behavior, DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues, DMW.DocPartBehaviorKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Behaviors? value)
    where OpenXmlElementType: DXW.Behaviors, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBehavior(openXmlElement, value?.Behavior);
      return openXmlElement;
    }
    return default;
  }
}
