namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public partial class BehaviorsImpl: ModelElementImpl, Behaviors
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.Behaviors? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Behaviors?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BehaviorsImpl(): base() {}
  
  public BehaviorsImpl(DocumentFormat.OpenXml.Wordprocessing.Behaviors openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.DocPartBehaviorKind? Behavior
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behavior>();
        return (DocumentModel.Wordprocessing.DocPartBehaviorKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Behavior>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.Behavior{ Val = (DocumentFormat.OpenXml.Wordprocessing.DocPartBehaviorValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
