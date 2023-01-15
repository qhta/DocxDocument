using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using Behaviors = DocumentFormat.OpenXml.Wordprocessing.Behaviors;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Entry Insertion Behaviors.
/// </summary>
public static class BehaviorsConverter
{
  public static DocPartBehaviorKind? GetBehavior(Behaviors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Behavior>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DocPartBehaviorValues, DocPartBehaviorKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBehavior(Behaviors? openXmlElement, DocPartBehaviorKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Behavior>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Behavior, DocPartBehaviorValues, DocPartBehaviorKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Behaviors? CreateModelElement(Behaviors? openXmlElement)
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
    where OpenXmlElementType : Behaviors, new()
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