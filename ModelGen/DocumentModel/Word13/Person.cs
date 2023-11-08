namespace DocumentModel.Word13;


/// <summary>
///   This element specifies contact information for an author of at least one comment or revision in the current document.
/// </summary>
public partial class Person: ModelElement<DXO13W.Person>
{
  public Person(): base(){ }
  
  public Person(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Person(DXO13W.Person openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public String? Contact
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Contact);
    }
    set
    {
      _ExistingElement.Contact = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   author, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Author
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Author);
    }
    set
    {
      _ExistingElement.Author = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   PresenceInfo.
  /// </summary>
  [DataMember]
  public DMW13.PresenceInfo? PresenceInfo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13W.PresenceInfo>();
      if (element != null)
        return PresenceInfoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13W.PresenceInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresenceInfoConverter.CreateOpenXmlElement<DXO13W.PresenceInfo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
