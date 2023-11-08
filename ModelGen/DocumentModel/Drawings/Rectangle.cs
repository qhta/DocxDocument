namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the rectangular bounding box for text within a custGeom shape. The default for this rectangle is the bounding box for the shape. This can be modified using this elements four attributes to inset or extend the text bounding box.
/// </summary>
public partial class Rectangle: ModelElement<DXD.Rectangle>
{
  public Rectangle(): base(){ }
  
  public Rectangle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Rectangle(DXD.Rectangle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the x coordinate of the left edge for a shape text rectangle. The units for this edge is specified in EMUs as the positioning here is based on the shape coordinate system. The width and height for this coordinate system are specified within the ext transform element.
  /// </summary>
  [DataMember]
  public String? Left
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Left);
    }
    set
    {
      _ExistingElement.Left = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Specifies the y coordinate of the top edge for a shape text rectangle. The units for this edge is specified in EMUs as the positioning here is based on the shape coordinate system. The width and height for this coordinate system are specified within the ext transform element.
  /// </summary>
  [DataMember]
  public String? Top
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Top);
    }
    set
    {
      _ExistingElement.Top = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Specifies the x coordinate of the right edge for a shape text rectangle. The units for this edge is specified in EMUs as the positioning here is based on the shape coordinate system. The width and height for this coordinate system are specified within the ext transform element.
  /// </summary>
  [DataMember]
  public String? Right
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Right);
    }
    set
    {
      _ExistingElement.Right = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Specifies the y coordinate of the bottom edge for a shape text rectangle. The units for this edge is specified in EMUs as the positioning here is based on the shape coordinate system. The width and height for this coordinate system are specified within the ext transform element.
  /// </summary>
  [DataMember]
  public String? Bottom
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Bottom);
    }
    set
    {
      _ExistingElement.Bottom = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
