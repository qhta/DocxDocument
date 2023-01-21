namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public static class BehaviorsConverter
{
  private static DMW.DocPartBehaviorKind? GetBehavior(DXW.Behaviors openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Behavior>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues, DMW.DocPartBehaviorKind>(itemElement.Val.Value);
    return null;
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
