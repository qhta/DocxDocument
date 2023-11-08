namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Document Variable.
/// </summary>
public partial class DocumentVariable: ModelElement<DXW.DocumentVariable>
{
  public DocumentVariable(): base(){ }
  
  public DocumentVariable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentVariable(DXW.DocumentVariable openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Variable Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Document Variable Value
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
  
}
