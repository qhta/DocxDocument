namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the extension list within which all future extensions of element type ext is defined. The extension list along with corresponding future extensions is used to extend the storage capabilities of the DrawingML framework. This allows for various new types of data to be stored natively within the framework.
/// </summary>
public partial class NonVisualGroupDrawingShapePropsExtensionList: ModelElement<DXD.NonVisualGroupDrawingShapePropsExtensionList>
{
  public NonVisualGroupDrawingShapePropsExtensionList(): base(){ }
  
  public NonVisualGroupDrawingShapePropsExtensionList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGroupDrawingShapePropsExtensionList(DXD.NonVisualGroupDrawingShapePropsExtensionList openXmlElement): base(openXmlElement) { }
  
}
