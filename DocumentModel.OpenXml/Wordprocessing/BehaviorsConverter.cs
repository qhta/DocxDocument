namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public static class BehaviorsConverter
{
  public static DocumentModel.Wordprocessing.DocPartBehaviorKind? GetBehavior(DocumentFormat.OpenXml.Wordprocessing.Behaviors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behavior>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues, DocumentModel.Wordprocessing.DocPartBehaviorKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBehavior(DocumentFormat.OpenXml.Wordprocessing.Behaviors? openXmlElement, DocumentModel.Wordprocessing.DocPartBehaviorKind? value)
  {
    if (openXmlElement != null)
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
  }
  
}
