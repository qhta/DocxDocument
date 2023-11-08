namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Layout Node.
/// </summary>
public partial class LayoutNode: ModelElement<DXDDD.LayoutNode>
{
  public LayoutNode(): base(){ }
  
  public LayoutNode(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LayoutNode(DXDDD.LayoutNode openXmlElement): base(openXmlElement) { }
  
  
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
  
  
  /// <summary>
  ///   Style Label
  /// </summary>
  [DataMember]
  public String? StyleLabel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.StyleLabel);
    }
    set
    {
      _ExistingElement.StyleLabel = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Move With
  /// </summary>
  [DataMember]
  public String? MoveWith
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MoveWith);
    }
    set
    {
      _ExistingElement.MoveWith = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
