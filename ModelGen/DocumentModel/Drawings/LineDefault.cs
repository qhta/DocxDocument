namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a default line that is used within a document.
/// </summary>
public partial class LineDefault: ModelElement<DXD.LineDefault>
{
  public LineDefault(): base(){ }
  
  public LineDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineDefault(DXD.LineDefault openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMD.ShapeProperties,DXD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ShapeProperties,DXD.ShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get
    {
      return _Element?.GetObject<DMD.BodyProperties,DXD.BodyProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BodyProperties,DXD.BodyProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get
    {
      return _Element?.GetObject<DMD.ListStyle,DXD.ListStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ListStyle,DXD.ListStyle>(value);
    }
  }
  
  [DataMember]
  public DMD.ShapeStyle? ShapeStyle
  {
    get
    {
      return _Element?.GetObject<DMD.ShapeStyle,DXD.ShapeStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ShapeStyle,DXD.ShapeStyle>(value);
    }
  }
  
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
