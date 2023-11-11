namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Choose Element.
/// </summary>
public partial class Choose: ModelElement<DXDDD.Choose>
{
  public Choose(): base(){ }
  
  public Choose(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Choose(DXDDD.Choose openXmlElement): base(openXmlElement) { }
  
  
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
  
  [DataMember]
  public DMDD.DiagramChooseElse? DiagramChooseElse
  {
    get
    {
      return _Element?.GetObject<DMDD.DiagramChooseElse,DXDDD.DiagramChooseElse>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.DiagramChooseElse,DXDDD.DiagramChooseElse>(value);
    }
  }
  
}
