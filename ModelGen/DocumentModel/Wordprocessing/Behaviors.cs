namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Insertion Behaviors.
/// </summary>
public partial class Behaviors: ModelElement<DXW.Behaviors>
{
  public Behaviors(): base(){ }
  
  public Behaviors(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Behaviors(DXW.Behaviors openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.ElementCollection<DocPartBehaviorKind>? Items
  {
    get
    {
      var collection = new Collection<DMW.DocPartBehaviorKind>();
      foreach (var item in _ExistingElement.Elements<>())
      {
        var newItem = ElementCollection<DocPartBehaviorKind>Converter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      if (collection.Count>0)
        return collection;
      return null;
    }
    set
    {
      _ExistingElement.RemoveAllChildren<DXW.Behavior>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = ElementCollection<DocPartBehaviorKind>Converter.CreateOpenXmlElement<DM.ElementCollection<Behavior>>(item);
          if (newItem != null)
            _ExistingElement.AddChild(newItem);
        }
      }
    }
  }
  
}
