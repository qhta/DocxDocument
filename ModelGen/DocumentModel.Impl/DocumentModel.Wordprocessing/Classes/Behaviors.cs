namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Insertion Behaviors.
/// </summary>
public class BehaviorsImpl: ModelElementImpl, Behaviors
{
  public DocumentFormat.OpenXml.Wordprocessing.Behaviors? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Behaviors?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<DocPartBehaviorKind>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
