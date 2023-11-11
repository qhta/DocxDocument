namespace DocumentModel.Math;


/// <summary>
///   Group-Character Properties.
/// </summary>
public partial class GroupCharProperties: ModelElement<DXM.GroupCharProperties>
{
  public GroupCharProperties(): base(){ }
  
  public GroupCharProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupCharProperties(DXM.GroupCharProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Group Character (Grouping Character).
  /// </summary>
  [DataMember]
  public DMM.AccentChar? AccentChar
  {
    get
    {
      return _Element?.GetObject<DMM.AccentChar,DXM.AccentChar>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.AccentChar,DXM.AccentChar>(value);
    }
  }
  
  
  /// <summary>
  ///   Position (Group Character).
  /// </summary>
  [DataMember]
  public DMM.Position? Position
  {
    get
    {
      return _Element?.GetObject<DMM.Position,DXM.Position>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Position,DXM.Position>(value);
    }
  }
  
  
  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  [DataMember]
  public DMM.VerticalJustification? VerticalJustification
  {
    get
    {
      return _Element?.GetObject<DMM.VerticalJustification,DXM.VerticalJustification>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.VerticalJustification,DXM.VerticalJustification>(value);
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ControlProperties,DXM.ControlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ControlProperties,DXM.ControlProperties>(value);
    }
  }
  
}
