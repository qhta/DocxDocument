namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public class OfficeStyleSheetExtensionList: ModelElement
{
  public Collection<OfficeStyleSheetExtension>? OfficeStyleSheetExtensions { get; set; }
}
