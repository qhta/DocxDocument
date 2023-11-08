namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the primary name for the current style in the document. This name can be used in an application's user interface as desired. The actual primary name for this style is stored in its val attribute.
/// </summary>
public partial class DocPartName: ModelElement<DXW.DocPartName>
{
  public DocPartName(): base(){ }
  
  public DocPartName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartName(DXW.DocPartName openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Built-In Entry
  /// </summary>
  [DataMember]
  public Boolean? Decorated
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Decorated);
    }
    set
    {
      _ExistingElement.Decorated = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
