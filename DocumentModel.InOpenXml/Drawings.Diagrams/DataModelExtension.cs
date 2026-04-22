using DocumentModel.Drawings.Office;

namespace DocumentModel.Drawings;
/// <summary>
///   Defines the DataModelExtension class.
/// </summary>
[OpenXmlType(typeof(DXD.DataModelExtension))]
[XmlRoot("DataModelExtension", Namespace = "DocumentModel.Drawings")]
public partial class DataModelExtension : Extension<DXD.DataModelExtension>
{
 /// <summary>
 /// Data Model Extension Block.
 /// </summary>
 [OpenXmlElement(typeof(DXOD.DataModelExtensionBlock))]
 public DataModelExtensionBlock? DataModelExtensionBlock { get => _DataModelExtensionBlock; set => UpdateField(ref _DataModelExtensionBlock, value, nameof(DataModelExtensionBlock)); }
 private DataModelExtensionBlock? _DataModelExtensionBlock;

 /// <summary>
 /// Recolor Images.
 /// </summary>
 [OpenXmlElement(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.RecolorImages))]
 public bool? RecolorImages { get => _RecolorImages; set => UpdateField(ref _RecolorImages, value, nameof(RecolorImages)); }
 private bool? _RecolorImages;
}