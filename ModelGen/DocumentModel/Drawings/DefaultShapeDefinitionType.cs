namespace DocumentModel.Drawings;


/// <summary>
///   Defines the DefaultShapeDefinitionType Class.
/// </summary>
public partial class DefaultShapeDefinitionType: ModelElement<DXD.DefaultShapeDefinitionType>
{
  public DefaultShapeDefinitionType(): base(){ }
  
  public DefaultShapeDefinitionType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DefaultShapeDefinitionType(DXD.DefaultShapeDefinitionType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Visual Properties.
  /// </summary>
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
  
  
  /// <summary>
  ///   BodyProperties.
  /// </summary>
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
  
  
  /// <summary>
  ///   ListStyle.
  /// </summary>
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
  
  
  /// <summary>
  ///   ShapeStyle.
  /// </summary>
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
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
