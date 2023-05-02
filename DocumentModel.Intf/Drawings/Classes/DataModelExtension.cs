using DocumentModel.Drawings.Office;

namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataModelExtension Class.
/// </summary>
public class DataModelExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public DataModelExtensionBlock? DataModelExtensionBlock { get; set; }

  public bool? RecolorImages { get; set; }
}