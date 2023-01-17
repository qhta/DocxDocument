namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public static class BehaviorsConverter
{
  private static DocumentModel.Wordprocessing.DocPartBehaviorKind? GetBehavior(DocumentFormat.OpenXml.Wordprocessing.Behaviors openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behavior>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues, DocumentModel.Wordprocessing.DocPartBehaviorKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBehavior(DocumentFormat.OpenXml.Wordprocessing.Behaviors openXmlElement, DocumentModel.Wordprocessing.DocPartBehaviorKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behavior>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Behavior, DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues, DocumentModel.Wordprocessing.DocPartBehaviorKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.Behaviors? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.Behaviors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Behaviors();
      value.Behavior = GetBehavior(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Behaviors? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.Behaviors, new()
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
