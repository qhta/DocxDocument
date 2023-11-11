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
      if (_Element==null)
        return null;
      var collection = new ElementCollection<DMW.DocPartBehaviorKind>();
      foreach (var item in _ExistingElement.Elements<DXW.Behavior>())
      {
        var newItem = EnumValueConverter.GetValue<DXW.Behavior,DM.DocPartBehaviorKind>(item);
        if (newItem is not null)
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
          var newItem = (item);
          if (newItem != null)
            _ExistingElement.AddChild(newItem);
        }
      }
    }
  }
  
}
