namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Else.
/// </summary>
public partial class DiagramChooseElse: ModelElement<DXDDD.DiagramChooseElse>
{
  public DiagramChooseElse(): base(){ }
  
  public DiagramChooseElse(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramChooseElse(DXDDD.DiagramChooseElse openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name
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
  
}
