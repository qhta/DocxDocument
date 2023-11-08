namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MarkupRangeType Class.
/// </summary>
public partial class MarkupRangeType: ModelElement<DXW.MarkupRangeType>
{
  public MarkupRangeType(): base(){ }
  
  public MarkupRangeType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkupRangeType(DXW.MarkupRangeType openXmlElement): base(openXmlElement) { }
  
  
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
