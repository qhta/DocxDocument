namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ObjectProperties Class.
/// </summary>
public partial class ObjectProperties: ModelElement<DXO13D.ObjectProperties>
{
  public ObjectProperties(): base(){ }
  
  public ObjectProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ObjectProperties(DXO13D.ObjectProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   objectId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   isActiveX, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? IsActiveX
  {
    get
    {
      return _Element?.IsActiveX?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.IsActiveX = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.IsActiveX = null;
    }
  }
  
  
  /// <summary>
  ///   linkType, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? LinkType
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LinkType);
    }
    set
    {
      _ExistingElement.LinkType = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
