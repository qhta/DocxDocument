namespace DocumentModel.Spreadsheet;

/// <summary>
/// Calculated Member.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICalculatedMemberExtensionList))]
public interface ICalculatedMember // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// mdx
  /// </summary>
  public string? Mdx { get ; set; }
  
  /// <summary>
  /// memberName
  /// </summary>
  public string? MemberName { get ; set; }
  
  /// <summary>
  /// hierarchy
  /// </summary>
  public string? Hierarchy { get ; set; }
  
  /// <summary>
  /// parent
  /// </summary>
  public string? ParentName { get ; set; }
  
  /// <summary>
  /// solveOrder
  /// </summary>
  public int? SolveOrder { get ; set; }
  
  /// <summary>
  /// set
  /// </summary>
  public bool? Set { get ; set; }
  
  /// <summary>
  /// CalculatedMemberExtensionList.
  /// </summary>
  public ICalculatedMemberExtensionList? CalculatedMemberExtensionList { get ; set; }
  
}
