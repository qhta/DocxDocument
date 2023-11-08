namespace DocumentModel.Math;


/// <summary>
///   Delimiter Function.
/// </summary>
public partial class Delimiter: ModelElement<DXM.Delimiter>
{
  public Delimiter(): base(){ }
  
  public Delimiter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Delimiter(DXM.Delimiter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Delimiter Properties.
  /// </summary>
  [DataMember]
  public DMM.DelimiterProperties? DelimiterProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.DelimiterProperties>();
      if (element != null)
        return DelimiterPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.DelimiterProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DelimiterPropertiesConverter.CreateOpenXmlElement<DXM.DelimiterProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
