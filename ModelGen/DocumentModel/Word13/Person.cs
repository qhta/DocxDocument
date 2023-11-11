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
      return _Element?.GetObject<DMW13.PresenceInfo,DXO13W.PresenceInfo>();
    }
    set
    {
      _ExistingElement.SetObject<DMW13.PresenceInfo,DXO13W.PresenceInfo>(value);
    }
  }
  
}
