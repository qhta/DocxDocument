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
      var element = _Element?.GetFirstChild<DXDDD.DiagramChooseElse>();
      if (element != null)
        return DiagramChooseElseConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.DiagramChooseElse>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DiagramChooseElseConverter.CreateOpenXmlElement<DXDDD.DiagramChooseElse>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
