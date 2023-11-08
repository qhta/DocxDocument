namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Control Class.
/// </summary>
public partial class Control: ModelElement<DXW.Control>
{
  public Control(): base(){ }
  
  public Control(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Control(DXW.Control openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Name for Embedded Control
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
  ///   Associated VML Data Reference
  /// </summary>
  [DataMember]
  public String? ShapeId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ShapeId);
    }
    set
    {
      _ExistingElement.ShapeId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Embedded Control Properties Relationship Reference
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
