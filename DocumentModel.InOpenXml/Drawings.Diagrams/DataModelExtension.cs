using DocumentModel.Drawings.Office;
namespace DocumentModel.Drawings;

/// <summary>
///   Defines the DataModelExtension class.
/// </summary>
[OpenXmlType(typeof(DXD.DataModelExtension))]
public class DataModelExtension : Extension<DXD.DataModelExtension>
{
  public DataModelExtensionBlock? DataModelExtensionBlock { get; set; }
  public bool? RecolorImages { get; set; }
}