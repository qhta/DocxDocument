namespace DocumentModel.Vml;


/// <summary>
///   Diagram Relationship.
/// </summary>
public partial class Relation: ModelElement<DXVO.Relation>
{
  public Relation(): base(){ }
  
  public Relation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Relation(DXVO.Relation openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Diagram Relationship Source Shape
  /// </summary>
  [DataMember]
  public String? SourceId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SourceId);
    }
    set
    {
      _ExistingElement.SourceId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Diagram Relationship Destination Shape
  /// </summary>
  [DataMember]
  public String? DestinationId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DestinationId);
    }
    set
    {
      _ExistingElement.DestinationId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Diagram Relationship Center Shape
  /// </summary>
  [DataMember]
  public String? CenterShapeId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CenterShapeId);
    }
    set
    {
      _ExistingElement.CenterShapeId = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
