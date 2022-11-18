namespace DocumentModel.Spreadsheet;

/// <summary>
/// Set MDX Metadata.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INameIndex))]
public interface IMdxSet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Set Definition Index
  /// </summary>
  public uint? SetDefinitionIndex { get ; set; }
  
  /// <summary>
  /// Sort By Member Index Count
  /// </summary>
  public uint? MemberIndexCount { get ; set; }
  
  /// <summary>
  /// Set Sort Order
  /// </summary>
  public MdxSetOrder? SortingOrder { get ; set; }
  
}
