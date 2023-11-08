namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Types.
/// </summary>
public partial class DocPartTypes: ModelElement<DXW.DocPartTypes>
{
  public DocPartTypes(): base(){ }
  
  public DocPartTypes(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartTypes(DXW.DocPartTypes openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Entry Is Of All Types
  /// </summary>
  [DataMember]
  public Boolean? All
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.All);
    }
    set
    {
      _ExistingElement.All = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  [DataMember]
  public DM.ElementCollection<DocPartKind>? Items
  {
    get
    {
      var collection = new Collection<DMW.DocPartKind>();
      foreach (var item in _ExistingElement.Elements<>())
      {
        var newItem = ElementCollection<DocPartKind>Converter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      if (collection.Count>0)
        return collection;
      return null;
    }
    set
    {
      _ExistingElement.RemoveAllChildren<DXW.DocPartType>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = ElementCollection<DocPartKind>Converter.CreateOpenXmlElement<DM.ElementCollection<DocPartType>>(item);
          if (newItem != null)
            _ExistingElement.AddChild(newItem);
        }
      }
    }
  }
  
}
