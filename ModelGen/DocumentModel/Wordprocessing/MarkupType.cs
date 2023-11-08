namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public partial class MarkupType: ModelElement<DXW.MarkupType>
{
  public MarkupType(): base(){ }
  
  public MarkupType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkupType(DXW.MarkupType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Annotation Identifier
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
  
}
