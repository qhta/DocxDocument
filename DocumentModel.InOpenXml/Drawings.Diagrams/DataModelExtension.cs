using DocumentModel.Drawings.Office;
namespace DocumentModel.Drawings;

/// <summary>
///   Defines the DataModelExtension class.
/// </summary>
[OpenXmlType(typeof(DXD.DataModelExtension))]
/// <summary>
/// Represents the Data Model Extension.
/// </summary>
public class DataModelExtension : Extension<DXD.DataModelExtension>
{
  /// <summary>
  /// Data Model Extension Block.
  /// </summary>
  public DataModelExtensionBlock? DataModelExtensionBlock { get; set; }
  /// <summary>
  /// Recolor Images.
  /// </summary>
  public bool? RecolorImages { get; set; }
}

