namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a rotation in 3D space.  A rotation in DrawingML is defined through the use of a latitude coordinate, a longitude coordinate, and a revolution about the axis as the latitude and longitude coordinates.
/// </summary>
public partial class Rotation: ModelElement<DXD.Rotation>
{
  public Rotation(): base(){ }
  
  public Rotation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Rotation(DXD.Rotation openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Defines the latitude value of the rotation.
  /// </summary>
  [DataMember]
  public Int32? Latitude
  {
    get => _Element?.Latitude?.Value;
    set => _ExistingElement.Latitude = value;
  }
  
  
  /// <summary>
  ///   Defines the longitude value of the rotation.
  /// </summary>
  [DataMember]
  public Int32? Longitude
  {
    get => _Element?.Longitude?.Value;
    set => _ExistingElement.Longitude = value;
  }
  
  
  /// <summary>
  ///   This attributes defines the revolution around the central axis in the rotation.
  /// </summary>
  [DataMember]
  public Int32? Revolution
  {
    get => _Element?.Revolution?.Value;
    set => _ExistingElement.Revolution = value;
  }
  
}
