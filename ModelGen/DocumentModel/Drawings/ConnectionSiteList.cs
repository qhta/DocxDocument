namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all the connection sites that are used for this shape. A connection site is specified by defining a point within the shape bounding box that can have a cxnSp element attached to it. These connection sites are specified using the shape coordinate system that is specified within the ext transform element.
/// </summary>
public partial class ConnectionSiteList: ModelElement<DXD.ConnectionSiteList>
{
  public ConnectionSiteList(): base(){ }
  
  public ConnectionSiteList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConnectionSiteList(DXD.ConnectionSiteList openXmlElement): base(openXmlElement) { }
  
}
