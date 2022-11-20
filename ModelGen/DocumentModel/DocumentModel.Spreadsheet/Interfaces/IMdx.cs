namespace DocumentModel.Spreadsheet;

/// <summary>
/// MDX Metadata Record.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMdxKpi))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMdxMemberProp))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMdxSet))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMdxTuple))]
public interface IMdx // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Connection Name Index
  /// </summary>
  public uint? NameIndex { get ; set; }
  
  /// <summary>
  /// Cube Function Tag
  /// </summary>
  public MdxFunctionValues? CubeFunction { get ; set; }
  
  /// <summary>
  /// Tuple MDX Metadata.
  /// </summary>
  public IMdxTuple? MdxTuple { get ; set; }
  
  /// <summary>
  /// Set MDX Metadata.
  /// </summary>
  public IMdxSet? MdxSet { get ; set; }
  
  /// <summary>
  /// Member Property MDX Metadata.
  /// </summary>
  public IMdxMemberProp? MdxMemberProp { get ; set; }
  
  /// <summary>
  /// KPI MDX Metadata.
  /// </summary>
  public IMdxKpi? MdxKpi { get ; set; }
  
}
